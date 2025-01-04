using System.Text;
using Discord.Net.Hanz.Nodes;
using Discord.Net.Hanz.Utils;
using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Discord.Net.Hanz.Tasks.V2.Nodes;

public sealed class ModelEqualityNode : Node
{
    private record Target(
        TypeRef Type,
        ImmutableEquatableArray<TypeRef> Implements,
        ImmutableEquatableArray<Property> Properties
    );

    private record Property(
        string Name,
        TypeRef Type,
        IEqualityCheck Check
    );

    private interface IEqualityCheck
    {
        string Format(string a, string b);
    }

    private record DefaultEqualityCheck(
        TypeRef Type
    ) : IEqualityCheck
    {
        public string Format(string a, string b)
            => $"EqualityComparer<{Type}>.Default.Equals({a}, {b})";
    }

    private record OptionalEqualityCheck(
        IEqualityCheck Inner
    ) : IEqualityCheck
    {
        public string Format(string a, string b)
            =>
                $"({a}.IsSpecified == {b}.IsSpecified) && (!{a}.IsSpecified || ({Inner.Format($"{a}.Value", $"{b}.Value")}))";
    }

    private record CollectionEqualityCheck(
        TypeRef Type
    ) : IEqualityCheck
    {
        public string Format(string a, string b)
        {
            if (Type.CanBeNull)
            {
                return $"({a} is null == {b} is null) && ({a} is null || {a}.SequenceEqual({b}!))";
            }

            return $"{a}.SequenceEquals({b})";
        }
    }

    private record DictionaryEqualityCheck(
        TypeRef Type,
        IEqualityCheck ValuesEqualityCheck
    ) : IEqualityCheck
    {
        public string Format(string a, string b)
        {
            return $"({a} is null == {b} is null) && ({a} is null || ({a}.Count == {b}.Count && {a}.All(kvp => {b}.ContainsKey(kvp.Key) && {ValuesEqualityCheck.Format("kvp.Value", $"{b}[kvp.Key]")})))";
        }
    }


    private readonly IncrementalKeyValueProvider<TypeRef, Target> _provider;

    public ModelEqualityNode(IncrementalGeneratorInitializationContext context, ILogger logger) : base(context, logger)
    {
        _provider = context
            .SyntaxProvider
            .ForAttributeWithMetadataName(
                "Discord.ModelEqualityAttribute",
                (node, _) => node is InterfaceDeclarationSyntax,
                Map
            )
            .WhereNotNull()
            .KeyedBy(x => x.Type);

        context.RegisterSourceOutput(
            _provider.Select(GenerateSpec)
        );
    }

    private SourceSpec GenerateSpec(Target target)
    {
        var implementedEqualityTypes = target.Implements
            .Where(_provider.ContainsKey)
            .Select(_provider.GetValue)
            .ToArray();

        var typeSpec = TypeSpec.From(target.Type)
            .AddModifiers("partial")
            .AddBases($"IEquatable<{target.Type}>")
            .AddMethods([
                new MethodSpec(
                    "Equals",
                    "bool",
                    Modifiers: new(["new"]),
                    Parameters: new([
                        ($"{target.Type}?", "other")
                    ]),
                    Body:
                    $"""
                     if(other is null) return false;

                     return
                         {
                             string.Join(
                                     $" &&{Environment.NewLine}",
                                     [
                                         ..target
                                             .Properties
                                             .Concat(implementedEqualityTypes.SelectMany(x => x.Properties))
                                             .Select(x =>
                                                 x.Check.Format($"this.{x.Name}", $"other.{x.Name}")
                                             )
                                     ]
                                 )
                                 .WithNewlinePadding(4)
                         };
                     """
                ),
                new(
                    "Equals",
                    "bool",
                    Parameters: new([
                        ($"{target.Type}?", "other")
                    ]),
                    ExplicitInterfaceImplementation: $"IEquatable<{target.Type}>",
                    Expression: "Equals(other)"
                ),
                ..implementedEqualityTypes
                    .SelectMany(IEnumerable<MethodSpec> (x) =>
                        [
                            new MethodSpec(
                                "Equals",
                                "bool",
                                Parameters: new([
                                    ($"{x.Type}?", "other")
                                ]),
                                ExplicitInterfaceImplementation: $"IEquatable<{x.Type}>",
                                Expression: $"other is {target.Type} self && Equals(self)"
                            ),
                            new MethodSpec(
                                "Equals",
                                "bool",
                                Parameters: new([
                                    ($"{x.Type}?", "other")
                                ]),
                                ExplicitInterfaceImplementation: x.Type.DisplayString,
                                Expression: $"other is {target.Type} self && Equals(self)"
                            )
                        ]
                    )
            ]);

        return new SourceSpec(
            $"ModelEquality/{target.Type.MetadataName}",
            target.Type.Namespace!,
            new([
                "Discord",
                "Discord.Models",
                "Discord.Models.Json",
                "System.Linq"
            ]),
            new([typeSpec])
        );
    }

    private static IEqualityCheck GetEqualityCheck(ITypeSymbol type, KnownTypes knownTypes)
    {
        if (type is INamedTypeSymbol {Name: "Optional", TypeArguments.Length: 1} opt)
            return new OptionalEqualityCheck(GetEqualityCheck(opt.TypeArguments[0], knownTypes));

        if (
            (
                type.GetCompatibleGenericBaseType(knownTypes.IDictionaryType) ?? 
                type.GetCompatibleGenericBaseType(knownTypes.IReadonlyDictionaryOfTKeyTValueType))
            is {TypeArguments.Length: 2} dict
            )
        {
            return new DictionaryEqualityCheck(new(type), GetEqualityCheck(dict.TypeArguments[1], knownTypes));
        }
        
        if (
            (
                type is IArrayTypeSymbol ||
                type.SpecialType
                    is SpecialType.System_Array
                    or SpecialType.System_Collections_IEnumerable
                    or SpecialType.System_Collections_Generic_IEnumerable_T
                    or SpecialType.System_Collections_Generic_IList_T
                    or SpecialType.System_Collections_Generic_ICollection_T
                    or SpecialType.System_Collections_Generic_IReadOnlyList_T
                    or SpecialType.System_Collections_Generic_IReadOnlyCollection_T
            )
            // ||
            // type
            //     .Interfaces
            //     .Any(x => x is {Name: "IEnumerable", TypeArguments.Length: 1})
        )
        {
            return new CollectionEqualityCheck(new(type));
        }

        return new DefaultEqualityCheck(new(type));
    }

    private Target? Map(GeneratorAttributeSyntaxContext context, CancellationToken token)
    {
        if (context is not {TargetSymbol: INamedTypeSymbol symbol, TargetNode: InterfaceDeclarationSyntax syntax})
            return null;

        if (syntax.Modifiers.IndexOf(SyntaxKind.PartialKeyword) == -1) return null;

        var knownTypes = context.SemanticModel.Compilation.GetKnownTypes();
        
        var props = symbol
            .GetMembers()
            .OfType<IPropertySymbol>()
            .Where(x =>
                !x.IsIndexer &&
                !x.IsStatic &&
                x.ExplicitInterfaceImplementations.Length == 0
            )
            .Select(x => new Property(
                x.Name,
                new(x.Type),
                GetEqualityCheck(x.Type, knownTypes)
            ))
            .ToImmutableEquatableArray();

        return new(
            new(symbol),
            symbol.AllInterfaces.Select(x => new TypeRef(x)).ToImmutableEquatableArray(),
            props
        );
    }
}