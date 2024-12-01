using System.Collections.Immutable;
using Discord.Net.Hanz.Nodes.TypeNodes;
using Discord.Net.Hanz.Tasks.Actors.Common;
using Discord.Net.Hanz.Tasks.Actors.Links.Nodes.Types;
using Discord.Net.Hanz.Tasks.Actors.Nodes;
using Discord.Net.Hanz.Utils;
using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Discord.Net.Hanz.Tasks.Actors.Links.Nodes.Modifiers;

public sealed class ExtensionNode :
    LinkNode,
    ITypeProducerNode<ExtensionNode.Extension>.WithParameters<ActorInfo>.Introspects<AncestorPathingIntrospection>
{
    public record Extension(
        ActorInfo ActorInfo,
        string Name,
        ImmutableEquatableArray<ExtensionSpec.Property> Properties
    );

    public record ExtensionSpec(
        string Actor,
        string Name,
        ImmutableEquatableArray<ExtensionSpec.Property> Properties
    )
    {
        public readonly record struct Property(
            string Name,
            string Type,
            string? Overloads,
            Property.Kind PropertyKind,
            ActorInfo? ActorInfo = null
        )
        {
            public enum Kind
            {
                Normal,
                LinkMirror,
                BackLinkMirror
            }

            public bool IsDefinedOnPath(TypePath path)
            {
                var isRoot = path.Equals(typeof(ActorNode), typeof(ExtensionNode));

                return PropertyKind switch
                {
                    Kind.Normal => isRoot,
                    Kind.LinkMirror => path.Contains<LinkTypeNode>() || isRoot,
                    Kind.BackLinkMirror => isRoot ||
                                           path.Equals(typeof(ActorNode), typeof(ExtensionNode), typeof(BackLinkNode)),
                    _ => false
                };
            }

            public static Property Create(IPropertySymbol symbol)
            {
                var kind = Kind.Normal;

                var linkMirrorAttribute = symbol.GetAttributes()
                    .FirstOrDefault(x => x.AttributeClass?.Name == "LinkMirrorAttribute");

                if (linkMirrorAttribute is not null)
                {
                    kind = linkMirrorAttribute
                        .NamedArguments
                        .FirstOrDefault(x => x.Key == "OnlyBackLinks")
                        .Value
                        .Value is true
                        ? Kind.BackLinkMirror
                        : Kind.LinkMirror;
                }


                return new Property(
                    MemberUtils.GetMemberName(symbol),
                    symbol.Type.ToDisplayString(),
                    symbol.ExplicitInterfaceImplementations.FirstOrDefault()?.ContainingType.ToDisplayString(),
                    kind
                );
            }
        }

        public static IEnumerable<ExtensionSpec> GetExtensions(
            ActorsTask.ActorSymbols target,
            CancellationToken cancellationToken)
        {
            var types = target
                .GetCoreActor()
                .GetTypeMembers()
                .Where(x => x.Name.EndsWith("Extension"))
                .Where(x => x
                    .GetAttributes()
                    .Any(x => x.AttributeClass?.Name == "LinkExtensionAttribute")
                );

            foreach (var extensionSymbol in types)
            {
                yield return new ExtensionSpec(
                    target.Actor.ToDisplayString(),
                    extensionSymbol.Name.Replace("Extension", string.Empty),
                    extensionSymbol
                        .GetMembers()
                        .OfType<IPropertySymbol>()
                        .Select(Property.Create)
                        .ToImmutableEquatableArray()
                );
            }
        }
    }

    private readonly IncrementalGroupingProvider<ActorInfo, ExtensionSpec> _extensions;

    public ExtensionNode(IncrementalGeneratorInitializationContext context, Logger logger) : base(context, logger)
    {
        _extensions = context.SyntaxProvider
            .ForAttributeWithMetadataName(
                "Discord.LinkExtensionAttribute",
                (node, _) => node is InterfaceDeclarationSyntax,
                ExtensionSpec? (context, token) =>
                {
                    if (context.SemanticModel.GetDeclaredSymbol(context.TargetNode) is not INamedTypeSymbol
                        {
                            ContainingType: not null
                        } symbol)
                        return null;

                    var ext = new ExtensionSpec(
                        symbol.ContainingType.ToDisplayString(),
                        symbol.Name.Replace("Extension", string.Empty),
                        symbol
                            .GetMembers()
                            .OfType<IPropertySymbol>()
                            .Select(ExtensionSpec.Property.Create)
                            .ToImmutableEquatableArray()
                    );

                    return ext;
                }
            )
            .WhereNonNull()
            .GroupBy(x => x.Actor)
            .TransformKeysVia(GetTask<ActorsTask>().ActorInfos);
    }

    public TypeSpec CreateSpec(AncestorPathingIntrospection introspection, Extension extension, TypePath path)
        => new(
            Name: extension.Name,
            Kind: TypeKind.Interface,
            Properties: extension.Properties
                .SelectMany(x =>
                    BuildExtensionProperty(path, x, extension)
                )
                .ToImmutableEquatableArray(),
            Bases: new([
                ..introspection.SemanticBases,
                ..introspection.AncestorBases.Select(x => $"{x.Actor}.{path.FormatRelative()}")
            ])
        );

    public static IEnumerable<PropertySpec> BuildExtensionProperty(
        TypePath path,
        ExtensionSpec.Property property,
        Extension extension)
    {
        if (!property.IsDefinedOnPath(path))
            yield break;

        if (property.PropertyKind is not ExtensionSpec.Property.Kind.Normal && property.ActorInfo is null)
            yield break;

        var hasNewKeyword = property.PropertyKind switch
        {
            ExtensionSpec.Property.Kind.Normal => false,
            ExtensionSpec.Property.Kind.LinkMirror or ExtensionSpec.Property.Kind.BackLinkMirror =>
                path.Contains<LinkTypeNode>(),
            _ => false
        };

        var propertyType = property.PropertyKind switch
        {
            ExtensionSpec.Property.Kind.Normal => property.Type,
            ExtensionSpec.Property.Kind.LinkMirror =>
                path.Equals(typeof(ActorNode), typeof(ExtensionNode))
                    ? property.ActorInfo!.Value.FormattedLink
                    : $"{property.ActorInfo!.Value.Actor}.{path.OfType<LinkTypeNode>().FormatRelative()}",
            ExtensionSpec.Property.Kind.BackLinkMirror =>
                path.Last?.Type == typeof(BackLinkNode)
                    ? $"{property.ActorInfo!.Value.Actor}.BackLink<TSource>"
                    : property.ActorInfo!.Value.Actor.DisplayString,
            _ => throw new ArgumentOutOfRangeException()
        };

        var spec = new PropertySpec(
            Name: property.Name,
            Type: propertyType,
            Modifiers: hasNewKeyword
                ? new(["new"])
                : ImmutableEquatableArray<string>.Empty
        );

        yield return spec;

        switch (property.PropertyKind)
        {
            case ExtensionSpec.Property.Kind.LinkMirror:
                foreach (var pathProduct in path.OfType<LinkTypeNode>().CartesianProduct())
                {
                    yield return new PropertySpec(
                        Name: property.Name,
                        Type: $"{property.ActorInfo!.Value.Actor.DisplayString}.{pathProduct.FormatRelative()}",
                        ExplicitInterfaceImplementation: $"{extension.ActorInfo.Actor}.{pathProduct}.{extension.Name}",
                        Expression: property.Name
                    );
                }

                break;
            case ExtensionSpec.Property.Kind.BackLinkMirror when path.Last?.Type == typeof(BackLinkNode):
                yield return new PropertySpec(
                    Name: property.Name,
                    Type: property.ActorInfo!.Value.Actor.DisplayString,
                    ExplicitInterfaceImplementation: $"{extension.ActorInfo.Actor}.{extension.Name}",
                    Expression: property.Name
                );
                break;
        }
    }

    public IncrementalValuesProvider<NodeGeneration<Extension, TParent>> Create<TParent>(
        IncrementalValuesProvider<NodeContext<TParent, ActorInfo>> provider,
        ContinuationContext<Extension, TParent> continuationContext)
    {
        continuationContext.AddChild(
            GetNode<BackLinkNode>(),
            x => x.ActorInfo
        );

        return _extensions
            .JoinByKey(
                provider.KeyedBy(x => x.Parameters),
                (actorInfo, extensions, context) => extensions
                    .Select(ext =>
                        MapExtension(
                            actorInfo,
                            context,
                            context.Path,
                            ext,
                            extensions
                        )
                    )
                    .ToImmutableEquatableArray()
            )
            .SelectMany((x, _) => x);

        NodeGeneration<Extension, TParent> MapExtension(
            ActorInfo info,
            NodeContext<TParent, ActorInfo> context,
            TypePath path,
            ExtensionSpec spec,
            ImmutableArray<ExtensionSpec> children)
        {
            var nextChildren = children.Remove(spec);

            path = path.Add<ExtensionNode>(spec.Name);

            return context.WithState(
                new Extension(info, spec.Name, spec.Properties),
                path,
                nextChildren.Select(ext => MapExtension(info, context, path, ext, nextChildren))
            );
        }
    }

    public IncrementalValuesProvider<IntrospectionResult<AncestorPathingIntrospection, Extension>> Introspect(
        IncrementalValuesProvider<IntrospectionContext<Extension>> provider
    ) => Introspect(provider, x => x.ActorInfo);
}