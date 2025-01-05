using System.Collections.Immutable;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.SourceGeneration;
using Discord.Net.Hanz.Nodes;
using Discord.Net.Hanz.Tasks.V2.Nodes.STJ;
using Discord.Net.Hanz.Utils;
using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;

namespace Discord.Net.Hanz.Tasks.V2.Nodes;

public record JsonModel(
    string FriendlyName,
    TypeRef Type,
    JsonConstructor? Constructor,
    ImmutableEquatableArray<JsonProperty> Properties,
    ImmutableEquatableArray<TypeRef> Interfaces,
    ImmutableEquatableArray<TypeRef> DirectModelInterfaces,
    TypeRef? Base);

public record JsonConstructor(
    ImmutableEquatableArray<string> PropertiesInit,
    ImmutableEquatableArray<JsonConstructorParam> ConstructorParams
);

public record JsonConstructorParam(
    string Name,
    TypeRef Type,
    int Position,
    bool HasDefaultValue,
    string DefaultValue
);

public record JsonProperty(
    string Name,
    string? JsonName,
    JsonPropertyTypeInfo TypeInfo,
    string TypeFriendlyName,
    JsonPropertyOverload? Overload,
    bool CanGet,
    bool CanSet
);

public record JsonPropertyOverload(
    TypeRef Interface,
    JsonPropertyTypeInfo TypeInfo
);

public abstract record JsonPropertyTypeInfo(
    TypeRef Type,
    string FriendlyName
)
{
    public virtual bool ShouldGenerateInSTJ { get; } = false;
}

public record BasicJsonPropertyTypeInfo(TypeRef Type, string FriendlyName) : JsonPropertyTypeInfo(Type, FriendlyName)
{
    public override bool ShouldGenerateInSTJ => true;
}

public enum JsonPrimitiveKind
{
    Number,
    Boolean,
    Char,
    String,
    ByteArray
}

public record PrimitiveJsonPropertyTypeInfo(
    TypeRef Type,
    string FriendlyName,
    JsonPrimitiveKind Kind
) : JsonPropertyTypeInfo(Type, FriendlyName)
{
    public override bool ShouldGenerateInSTJ => true;
}

public record OptionalJsonPropertyTypeInfo(
    TypeRef Type,
    string FriendlyName,
    JsonPropertyTypeInfo Inner
) : JsonPropertyTypeInfo(Type, FriendlyName);

public record CollectionJsonPropertyTypeInfo(
    TypeRef Type,
    string FriendlyName,
    JsonPropertyTypeInfo Inner
) : JsonPropertyTypeInfo(Type, FriendlyName);

public record DictionaryJsonPropertyTypeInfo(
    TypeRef Type,
    string FriendlyName,
    JsonPropertyTypeInfo KeyInfo,
    JsonPropertyTypeInfo ValueInfo
) : JsonPropertyTypeInfo(Type, FriendlyName);

public sealed class JsonModelNode : Node
{
    public IncrementalKeyValueProvider<TypeRef, JsonModel> ModelsProvider { get; }

    public JsonModelNode(IncrementalGeneratorInitializationContext context, ILogger logger) : base(context, logger)
    {
        ModelsProvider = context
            .SyntaxProvider
            .ForAttributeWithMetadataName(
                "Discord.JsonModelAttribute",
                (node, _) => node is RecordDeclarationSyntax or ClassDeclarationSyntax,
                Map
            )
            .WhereNotNull()
            .KeyedBy(x => x.Type);
    }

    private JsonModel? Map(GeneratorAttributeSyntaxContext context, CancellationToken token)
    {
        if (context is not {TargetNode: TypeDeclarationSyntax syntax, TargetSymbol: INamedTypeSymbol symbol})
            return null;

        if (syntax.Modifiers.IndexOf(SyntaxKind.PartialKeyword) == -1)
            return null;

        var knownTypes = context.SemanticModel.Compilation.GetKnownTypes();

        var selectedProps = symbol
            .GetMembers()
            .OfType<IPropertySymbol>()
            .Where(ShouldIncludeProperty)
            .ToArray();

        var props = selectedProps
            .Select(x => GetJsonProperty(x, symbol, knownTypes))
            .ToImmutableEquatableArray();

        // var interfaceMembers = symbol.AllInterfaces
        //     .SelectMany(x => x.GetMembers())
        //     .Distinct(SymbolEqualityComparer.Default)
        //     .ToArray();

        return new JsonModel(
            GetFriendlyName(symbol),
            new(symbol),
            GetConstructor(symbol, selectedProps),
            props,
            symbol.AllInterfaces
                .Select(x => new TypeRef(x))
                .ToImmutableEquatableArray(),
            symbol.Interfaces
                .Where(ImplementsModelInterface)
                .Select(x => new TypeRef(x))
                .ToImmutableEquatableArray(),
            symbol.BaseType is not null
                ? new(symbol.BaseType)
                : null
        );
    }

    private static bool ImplementsModelInterface(INamedTypeSymbol symbol)
        => symbol.AllInterfaces.Any(x => x.Name is "IModel") &&
           symbol.Name is not "IModel" and not "IEntityModel";

    private static string GetFriendlyName(ITypeSymbol symbol)
    {
        if (symbol is IArrayTypeSymbol array)
        {
            return $"{GetFriendlyName(array.ElementType)}{(array.Rank == 1 ? "Array" : $"Array{array.Rank}D")}";
        }

        if (symbol is not INamedTypeSymbol {IsGenericType: true} namedType)
            return symbol.Name;

        var sb = new StringBuilder(symbol.Name);

        foreach (var typeArg in namedType.TypeArguments)
        {
            sb.Append(GetFriendlyName(typeArg));
        }

        return sb.ToString();
    }

    private JsonConstructor? GetConstructor(INamedTypeSymbol symbol, IPropertySymbol[] props)
    {
        var required = props
            .Where(x => x.IsRequired)
            .Select(x => x.Name)
            .ToImmutableEquatableArray();

        var ctor = GetCtor();

        if (required.Count == 0 && ctor is null) return null;

        return new(
            required,
            ctor?.Parameters
                .Select((x, i) => new JsonConstructorParam(
                    x.Name,
                    new(x.Type),
                    i,
                    x.HasExplicitDefaultValue,
                    x.HasExplicitDefaultValue
                        ? SyntaxUtils.FormatLiteral(x.ExplicitDefaultValue, x.Type.ToDisplayString())
                        : $"default({x.Type})"
                ))
                .ToImmutableEquatableArray()
            ?? ImmutableEquatableArray<JsonConstructorParam>.Empty
        );

        IMethodSymbol? GetCtor()
        {
            IMethodSymbol? ctorWithAttribute = null;
            IMethodSymbol? publicParameterlessCtor = null;
            IMethodSymbol? lonePublicCtor = null;

            var ctors = symbol.Constructors
                .Where(x =>
                    !x.IsStatic &&
                    !(x.IsImplicitlyDeclared && symbol.IsValueType && x.Parameters.Length == 0)
                )
                .ToArray();

            var publicCtors = ctors
                .Where(x => x.DeclaredAccessibility is Accessibility.Public)
                .ToArray();

            if (publicCtors.Length == 1)
                lonePublicCtor = publicCtors[0];

            foreach (var ctor in publicCtors)
            {
                if (ctor.HasAttribute("System.Text.Json.Serialization.JsonConstructorAttribute"))
                {
                    if (ctorWithAttribute is not null)
                        return null;

                    ctorWithAttribute = ctor;
                }
                else if (ctor.Parameters.Length == 0)
                    publicParameterlessCtor = ctor;
            }

            foreach (var ctor in ctors.Except(publicCtors))
            {
                if (ctor.HasAttribute("System.Text.Json.Serialization.JsonConstructorAttribute"))
                {
                    if (ctorWithAttribute is not null)
                        return null;

                    ctorWithAttribute = ctor;
                }
            }

            return ctorWithAttribute ?? publicParameterlessCtor ?? lonePublicCtor;
        }
    }

    private JsonProperty GetJsonProperty(IPropertySymbol property, INamedTypeSymbol model, KnownTypes knownTypes)
    {
        var ifaceMember = model.AllInterfaces
            .SelectMany(x => x.GetMembers().OfType<IPropertySymbol>())
            .FirstOrDefault(x => x.Name == property.Name);

        return new(
            property.Name,
            GetJsonName(property),
            GetPropertyType(property.Type, knownTypes),
            GetFriendlyName(property.Type),
            ifaceMember is not null
                ? new JsonPropertyOverload(new(ifaceMember.ContainingType),
                    GetPropertyType(ifaceMember.Type, knownTypes))
                : null,
            property.GetMethod is not null,
            property.SetMethod is {IsInitOnly: false}
        );
    }

    private static string? GetJsonName(IPropertySymbol property)
        => property.GetAttributes()
                .FirstOrDefault(x =>
                    x.AttributeClass?.ToDisplayString() is "System.Text.Json.Serialization.JsonPropertyNameAttribute")
                ?.ConstructorArguments
                .FirstOrDefault()
            is {Kind: TypedConstantKind.Primitive} arg
            ? arg.Value as string
            : null;

    private static bool ShouldIncludeProperty(IPropertySymbol property)
    {
        return
            !property.HasAttribute("System.Runtime.CompilerServices.CompilerGeneratedAttribute")
            &&
            property.ExplicitInterfaceImplementations.Length == 0
            &&
            !property.HasAttribute("System.Text.Json.Serialization.JsonIgnoreAttribute")
            &&
            property.HasAttribute("System.Text.Json.Serialization.JsonPropertyNameAttribute");
    }

    private static JsonPropertyTypeInfo GetPropertyType(ITypeSymbol type, KnownTypes knownTypes)
    {
        if (type.GetCompatibleGenericBaseType(knownTypes.Optional) is {TypeArguments.Length: 1} opt)
        {
            return new OptionalJsonPropertyTypeInfo(
                new(type),
                GetFriendlyName(type),
                GetPropertyType(opt.TypeArguments[0], knownTypes)
            );
        }

        JsonPrimitiveKind? primitiveType = type.SpecialType switch
        {
            SpecialType.System_SByte
                or SpecialType.System_Int16
                or SpecialType.System_Int32
                or SpecialType.System_Int64
                or SpecialType.System_Byte
                or SpecialType.System_UInt16
                or SpecialType.System_UInt32
                or SpecialType.System_UInt64
                or SpecialType.System_Single
                or SpecialType.System_Double
                or SpecialType.System_Decimal
                => JsonPrimitiveKind.Number,
            SpecialType.System_Boolean => JsonPrimitiveKind.Boolean,
            SpecialType.System_Char => JsonPrimitiveKind.Char,
            SpecialType.System_String => JsonPrimitiveKind.String,
            _ when type.Equals(knownTypes.ByteArrayType, SymbolEqualityComparer.Default)
                => JsonPrimitiveKind.ByteArray,
            _ => null
        };

        if (primitiveType is not null)
            return new PrimitiveJsonPropertyTypeInfo(new(type), GetFriendlyName(type), primitiveType.Value);
        
        if (
            TryResolveCollectionType(
                type,
                knownTypes,
                out var keyType,
                out var valueType,
                out var collectionType,
                out var immutableCollectionFactoryTypeFullName,
                out var needsRuntimeType
            )
        )
        {
        }

        return new BasicJsonPropertyTypeInfo(new(type), GetFriendlyName(type));
    }

    private static bool TryResolveCollectionType(
        ITypeSymbol type,
        KnownTypes knownTypes,
        out ITypeSymbol? keyType,
        out ITypeSymbol? valueType,
        out CollectionType collectionType,
        out string? immutableCollectionFactoryTypeFullName,
        out bool needsRuntimeType)
    {
        INamedTypeSymbol? actualTypeToConvert;
        valueType = null;
        keyType = null;
        collectionType = default;
        immutableCollectionFactoryTypeFullName = null;
        needsRuntimeType = false;

        if (SymbolEqualityComparer.Default.Equals(type.OriginalDefinition, knownTypes.MemoryType))
        {
            Debug.Assert(!SymbolEqualityComparer.Default.Equals(type, knownTypes.MemoryByteType));
            valueType = ((INamedTypeSymbol) type).TypeArguments[0];
            collectionType = CollectionType.MemoryOfT;
            return true;
        }

        if (SymbolEqualityComparer.Default.Equals(type.OriginalDefinition, knownTypes.ReadOnlyMemoryType))
        {
            Debug.Assert(!SymbolEqualityComparer.Default.Equals(type, knownTypes.ReadOnlyMemoryByteType));
            valueType = ((INamedTypeSymbol) type).TypeArguments[0];
            collectionType = CollectionType.ReadOnlyMemoryOfT;
            return true;
        }

        // IAsyncEnumerable<T> takes precedence over IEnumerable.
        if (type.GetCompatibleGenericBaseType(knownTypes.IAsyncEnumerableOfTType) is INamedTypeSymbol
            iAsyncEnumerableType)
        {
            valueType = iAsyncEnumerableType.TypeArguments[0];
            collectionType = CollectionType.IAsyncEnumerableOfT;
            return true;
        }

        if (!knownTypes.IEnumerableType.IsAssignableFrom(type))
        {
            // Type is not IEnumerable and therefore not a collection type
            return false;
        }

        if (type is IArrayTypeSymbol arraySymbol)
        {
            Debug.Assert(arraySymbol.Rank == 1, "multi-dimensional arrays should have been handled earlier.");
            collectionType = CollectionType.Array;
            valueType = arraySymbol.ElementType;
        }
        else if ((actualTypeToConvert = type.GetCompatibleGenericBaseType(knownTypes.KeyedCollectionType)) != null)
        {
            collectionType = CollectionType.ICollectionOfT;
            valueType = actualTypeToConvert.TypeArguments[1];
        }
        else if ((actualTypeToConvert = type.GetCompatibleGenericBaseType(knownTypes.ListOfTType)) != null)
        {
            collectionType = CollectionType.List;
            valueType = actualTypeToConvert.TypeArguments[0];
        }
        else if ((actualTypeToConvert = type.GetCompatibleGenericBaseType(knownTypes.DictionaryOfTKeyTValueType)) !=
                 null)
        {
            collectionType = CollectionType.Dictionary;
            keyType = actualTypeToConvert.TypeArguments[0];
            valueType = actualTypeToConvert.TypeArguments[1];
        }
        else if (knownTypes.IsImmutableDictionaryType(type, out immutableCollectionFactoryTypeFullName))
        {
            collectionType = CollectionType.ImmutableDictionary;
            ImmutableArray<ITypeSymbol> genericArgs = ((INamedTypeSymbol) type).TypeArguments;
            keyType = genericArgs[0];
            valueType = genericArgs[1];
        }
        else if ((actualTypeToConvert = type.GetCompatibleGenericBaseType(knownTypes.IDictionaryOfTKeyTValueType)) !=
                 null)
        {
            collectionType = CollectionType.IDictionaryOfTKeyTValue;
            keyType = actualTypeToConvert.TypeArguments[0];
            valueType = actualTypeToConvert.TypeArguments[1];
            needsRuntimeType = SymbolEqualityComparer.Default.Equals(type, actualTypeToConvert);
        }
        else if ((actualTypeToConvert =
                     type.GetCompatibleGenericBaseType(knownTypes.IReadonlyDictionaryOfTKeyTValueType)) != null)
        {
            collectionType = CollectionType.IReadOnlyDictionary;
            keyType = actualTypeToConvert.TypeArguments[0];
            valueType = actualTypeToConvert.TypeArguments[1];
            needsRuntimeType = SymbolEqualityComparer.Default.Equals(type, actualTypeToConvert);
        }
        else if (knownTypes.IsImmutableEnumerableType(type, out immutableCollectionFactoryTypeFullName))
        {
            collectionType = CollectionType.ImmutableEnumerable;
            valueType = ((INamedTypeSymbol) type).TypeArguments[0];
        }
        else if ((actualTypeToConvert = type.GetCompatibleGenericBaseType(knownTypes.IListOfTType)) != null)
        {
            collectionType = CollectionType.IListOfT;
            valueType = actualTypeToConvert.TypeArguments[0];
        }
        else if ((actualTypeToConvert = type.GetCompatibleGenericBaseType(knownTypes.ISetOfTType)) != null)
        {
            collectionType = CollectionType.ISet;
            valueType = actualTypeToConvert.TypeArguments[0];
        }
        else if ((actualTypeToConvert = type.GetCompatibleGenericBaseType(knownTypes.ICollectionOfTType)) != null)
        {
            collectionType = CollectionType.ICollectionOfT;
            valueType = actualTypeToConvert.TypeArguments[0];
        }
        else if ((actualTypeToConvert = type.GetCompatibleGenericBaseType(knownTypes.StackOfTType)) != null)
        {
            collectionType = CollectionType.StackOfT;
            valueType = actualTypeToConvert.TypeArguments[0];
        }
        else if ((actualTypeToConvert = type.GetCompatibleGenericBaseType(knownTypes.QueueOfTType)) != null)
        {
            collectionType = CollectionType.QueueOfT;
            valueType = actualTypeToConvert.TypeArguments[0];
        }
        else if ((actualTypeToConvert = type.GetCompatibleGenericBaseType(knownTypes.ConcurrentStackType)) != null)
        {
            collectionType = CollectionType.ConcurrentStack;
            valueType = actualTypeToConvert.TypeArguments[0];
        }
        else if ((actualTypeToConvert = type.GetCompatibleGenericBaseType(knownTypes.ConcurrentQueueType)) != null)
        {
            collectionType = CollectionType.ConcurrentQueue;
            valueType = actualTypeToConvert.TypeArguments[0];
        }
        else if ((actualTypeToConvert = type.GetCompatibleGenericBaseType(knownTypes.IEnumerableOfTType)) != null)
        {
            collectionType = CollectionType.IEnumerableOfT;
            valueType = actualTypeToConvert.TypeArguments[0];
        }
        else if (knownTypes.IDictionaryType.IsAssignableFrom(type))
        {
            collectionType = CollectionType.IDictionary;
            keyType = knownTypes.StringType;
            valueType = knownTypes.ObjectType;
            needsRuntimeType = SymbolEqualityComparer.Default.Equals(type, actualTypeToConvert);
        }
        else if (knownTypes.IListType.IsAssignableFrom(type))
        {
            collectionType = CollectionType.IList;
            valueType = knownTypes.ObjectType;
        }
        else if (knownTypes.StackType.IsAssignableFrom(type))
        {
            collectionType = CollectionType.Stack;
            valueType = knownTypes.ObjectType;
        }
        else if (knownTypes.QueueType.IsAssignableFrom(type))
        {
            collectionType = CollectionType.Queue;
            valueType = knownTypes.ObjectType;
        }
        else
        {
            collectionType = CollectionType.IEnumerable;
            valueType = knownTypes.ObjectType;
        }

        return true;
    }
}