using Discord.Net.Hanz.Nodes;
using Discord.Net.Hanz.Utils;
using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Discord.Net.Hanz.Tasks.V2.Nodes;

public class PartialModelsNode : Node
{
    private sealed class TargetTypeComparer : IEqualityComparer<PartialTarget>
    {
        public static readonly TargetTypeComparer Instance = new();

        public bool Equals(PartialTarget? x, PartialTarget? y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (x is null) return false;
            if (y is null) return false;
            return x.Type.Equals(y.Type);
        }

        public int GetHashCode(PartialTarget obj)
            => obj.Type.GetHashCode();
    }

    private record PartialTarget(
        TypeRef Type,
        ImmutableEquatableArray<PartialTarget> Additional
    );

    private record PartialInterfaceTarget(
        TypeRef Type,
        ImmutableEquatableArray<TypeRef> Implements,
        ImmutableEquatableArray<PartialProperty> Properties,
        ImmutableEquatableArray<PartialTarget> Additional
    ) : PartialTarget(Type, Additional);

    private record PartialJsonTarget(
        TypeRef Type,
        TypeRef? Base,
        ImmutableEquatableArray<TypeRef> Interfaces,
        ImmutableEquatableArray<PartialJsonProperty> Properties,
        ImmutableEquatableArray<PartialTarget> Additional
    ) : PartialTarget(Type, Additional);

    private record PartialProperty(
        TypeRef Type,
        TypeRef PartialType,
        string Name
    );

    private record PartialJsonProperty(
        TypeRef Type,
        TypeRef PartialType,
        string Name,
        string JsonName
    );

    private readonly IncrementalKeyValueProvider<TypeRef, PartialTarget> _partialProvider;

    public PartialModelsNode(IncrementalGeneratorInitializationContext context, ILogger logger) : base(context, logger)
    {
        _partialProvider = context
            .SyntaxProvider
            .ForAttributeWithMetadataName(
                "Discord.HasPartialVariantAttribute",
                (node, _) => node is TypeDeclarationSyntax,
                MapTarget
            )
            .WhereNotNull()
            .Collect()
            .SelectMany((x, _) => x
                .SelectMany(IEnumerable<PartialTarget> (x) => [x, ..x.Additional])
                .Distinct(TargetTypeComparer.Instance)
            )
            .KeyedBy(x => x.Type);

        context.RegisterSourceOutput(
            _partialProvider
                .Select(CreateSpec)
                .WhereNotNull()
        );
    }

    private SourceSpec? CreateSpec(PartialTarget target)
    {
        var typeSpec = target switch
        {
            PartialJsonTarget json => CreatePartialJsonSpec(json),
            PartialInterfaceTarget iface => CreatePartialInterfaceSpec(iface),
            _ => null
        };

        if (typeSpec is null) return null;

        return new SourceSpec(
            $"PartialJsonModels/{target.Type.MetadataName}",
            target.Type.Namespace!,
            new([
                "Discord",
                "Discord.Models",
                "Discord.Models.Json",
                "System.Text.Json.Serialization"
            ]),
            new([
                typeSpec
            ])
        );
    }

    private static string GetPartialName(TypeRef type)
    {
        if (type.TypeKind is TypeKind.Interface)
            return $"IPartial{type.Name.Substring(1, type.Name.Length - 1)}";

        return $"Partial{type.Name}";
    }

    private TypeSpec CreatePartialInterfaceSpec(PartialInterfaceTarget target)
    {
        var typeSpec = new TypeSpec(
            GetPartialName(target.Type),
            TypeKind.Interface,
            Accessibility.Public,
            Modifiers: new(["partial"]),
            Properties: new(
                [
                    ..target.Properties
                        .Select(x => new PropertySpec(
                            x.PartialType.DisplayString,
                            x.Name,
                            AutoGet: Accessibility.Public
                        )),
                    new(
                        "Type",
                        "UnderlyingModelType",
                        ExplicitInterfaceImplementation: "IPartialModel",
                        Expression: $"typeof({target.Type})"
                    )
                ]
            )
        );

        typeSpec = typeSpec.AddBases([
            "IPartialModel",
            ..target.Implements.Where(x => x.Name is "IEntityModel").Select(x => x.ReferenceName),
            ..target.Implements.Where(_partialProvider.ContainsKey)
                .Select(x => $"{x.Namespace}.{GetPartialName(x)}")
        ]);

        return typeSpec;
    }

    private TypeSpec CreatePartialJsonSpec(PartialJsonTarget target)
    {
        var typeSpec = new TypeSpec(
            GetPartialName(target.Type),
            TypeKind.Class,
            Accessibility.Public,
            Modifiers: new(["partial"]),
            Properties: new(
                target.Properties
                    .Select(x => new PropertySpec(
                        x.PartialType.DisplayString,
                        x.Name,
                        Accessibility.Public,
                        AutoGet: Accessibility.Public,
                        AutoSet: Accessibility.Public,
                        Attributes: new([
                            $"[JsonPropertyName({x.JsonName.Quote()})]"
                        ])
                    ))
            )
        );

        if (target.Base is not null)
            typeSpec = typeSpec.AddBaseClass($"{target.Base.Namespace}.{GetPartialName(target.Base)}");

        typeSpec = typeSpec.AddBases(
            target.Interfaces.Where(_partialProvider.ContainsKey)
                .Select(x => $"{x.Namespace}.{GetPartialName(x)}")
        );

        return typeSpec;
    }

    private PartialTarget? MapTarget(GeneratorAttributeSyntaxContext context, CancellationToken token)
    {
        if (context is not
            {TargetNode: TypeDeclarationSyntax syntax, TargetSymbol: INamedTypeSymbol symbol, Attributes.Length: 1})
            return null;

        var knownTypes = context.SemanticModel.Compilation.GetKnownTypes();

        switch (symbol.TypeKind)
        {
            case TypeKind.Class:
                return MapJsonTarget(symbol, knownTypes);
            case TypeKind.Interface:
                return MapInterfaceTarget(symbol, knownTypes);
            default: return null;
        }
    }

    private PartialJsonTarget? MapJsonTarget(
        INamedTypeSymbol symbol,
        KnownTypes knownTypes,
        Dictionary<INamedTypeSymbol, PartialTarget>? additional = null)
    {
        additional ??= new Dictionary<INamedTypeSymbol, PartialTarget>(SymbolEqualityComparer.Default);

        if (MapJsonProperties(symbol, knownTypes, additional) is not { } props)
            return null;

        return new(
            new(symbol),
            symbol.BaseType is not null && additional.ContainsKey(symbol.BaseType)
                ? new(symbol.BaseType)
                : null,
            symbol.Interfaces.Select(x => new TypeRef(x)).ToImmutableEquatableArray(),
            props,
            additional.Values.ToImmutableEquatableArray()
        );
    }

    private PartialInterfaceTarget? MapInterfaceTarget(
        INamedTypeSymbol symbol,
        KnownTypes knownTypes,
        Dictionary<INamedTypeSymbol, PartialTarget>? additional = null)
    {
        if (!ImplementsModelInterface(symbol)) return null;

        additional ??= new(SymbolEqualityComparer.Default);

        if (additional.TryGetValue(symbol, out var existing) && existing is PartialInterfaceTarget existingIface)
            return existingIface;


        return new(
            new(symbol),
            symbol.AllInterfaces.Select(x => new TypeRef(x)).ToImmutableEquatableArray(),
            symbol
                .GetMembers()
                .OfType<IPropertySymbol>()
                .Where(ShouldMapProperty)
                .Select(prop => new PartialProperty(
                    new(prop.Type),
                    GetPartialType(prop, knownTypes),
                    prop.Name
                ))
                .ToImmutableEquatableArray(),
            symbol
                .AllInterfaces
                .Where(ImplementsModelInterface)
                .Where(x => !additional.ContainsKey(x))
                .Select(x => MapInterfaceTarget(x, knownTypes))
                .Where(x => x is not null)!
                .ToImmutableEquatableArray<PartialTarget>()
        );
    }

    private static bool ImplementsModelInterface(INamedTypeSymbol symbol)
        => symbol.AllInterfaces.Any(x => x.Name is "IModel") &&
           symbol.Name is not "IModel" and not "IEntityModel";

    private ImmutableEquatableArray<PartialJsonProperty>? MapJsonProperties(
        INamedTypeSymbol symbol,
        KnownTypes knownTypes,
        Dictionary<INamedTypeSymbol, PartialTarget> additional
    )
    {
        var props = symbol
            .GetMembers()
            .OfType<IPropertySymbol>()
            .Where(ShouldMapJsonProperty)
            .Select(MapProperty)
            .ToImmutableEquatableArray();

        if (props.Count == 0)
            return null;

        foreach (var baseType in TypeUtils.GetBaseTypes(symbol).Where(x => !additional.ContainsKey(x)))
        {
            if (MapJsonTarget(baseType, knownTypes, additional) is not { } baseTarget)
                continue;

            additional[baseType] = baseTarget;

            // var baseProps = MapJsonProperties(baseType, knownTypes, additional);
            //
            // if (baseProps is not null)
            // {
            //     additional[baseType] = new PartialJsonTarget(
            //         new(baseType),
            //         baseType.BaseType is not null && additional.ContainsKey(baseType.BaseType)
            //             ? new(baseType.BaseType)
            //             : null,
            //         baseType.Interfaces.Select(x => new TypeRef(x)).ToImmutableEquatableArray(),
            //         baseProps,
            //         ImmutableEquatableArray<PartialTarget>.Empty
            //     );
            // }
        }

        foreach (var iface in symbol.Interfaces.Where(ImplementsModelInterface))
        {
            if (additional.ContainsKey(iface) || MapInterfaceTarget(iface, knownTypes, additional) is not
                    { } ifaceTarget)
                continue;

            additional[iface] = ifaceTarget;
        }

        return props;


        PartialJsonProperty MapProperty(IPropertySymbol property)
        {
            return new(
                new(property.Type),
                GetPartialType(property, knownTypes),
                property.Name,
                GetJsonName(property)
            );
        }
    }

    private TypeRef GetPartialType(IPropertySymbol property, KnownTypes knownTypes)
    {
        if (property.Type.Name is "Optional")
            return new(property.Type);

        return new(knownTypes.Optional!.Construct(property.Type));
    }

    private string GetJsonName(IPropertySymbol property)
    {
        var attribute = property.GetAttributes().FirstOrDefault(x =>
            x.AttributeClass?.ToDisplayString() == "System.Text.Json.Serialization.JsonPropertyNameAttribute"
        );

        return attribute?.ConstructorArguments.FirstOrDefault() is {Kind: TypedConstantKind.Primitive} arg
            ? arg.Value as string ?? property.Name
            : property.Name;
    }

    private bool ShouldMapJsonProperty(IPropertySymbol property) =>
        property.HasAttribute("System.Text.Json.Serialization.JsonPropertyNameAttribute") &&
        !property.HasAttribute("System.Text.Json.Serialization.JsonIgnoreAttribute") &&
        ShouldMapProperty(property);

    private bool ShouldMapProperty(IPropertySymbol property)
        => property.ExplicitInterfaceImplementations.Length == 0 &&
           !property.IsIndexer &&
           !property.HasAttribute("Discord.PartialIgnoreAttribute");
}