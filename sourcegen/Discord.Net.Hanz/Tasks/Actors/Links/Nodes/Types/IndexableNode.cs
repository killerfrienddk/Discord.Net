using Discord.Net.Hanz.Nodes.TypeNodes;
using Discord.Net.Hanz.Nodes.TypeNodes.Implementers;
using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;

namespace Discord.Net.Hanz.Tasks.Actors.Links.Nodes.Types;

public class IndexableNode :
    BaseLinkTypeNode
{
    public IndexableNode(IncrementalGeneratorInitializationContext context, Logger logger) : base(context, logger)
    {
    }

    protected override bool ShouldImplement(LinkTypeNode.State state)
        => state.Entry.Type.Name == "Indexable" && state.IsTemplate;

    protected override IncrementalValuesProvider<(Context Context, ILinkImplmenter.LinkSpec Implementation)> Create(
        IncrementalValuesProvider<Context> provider)
    {
        return provider.Select((context, token) => (context, CreateInterfaceSpec(context, token)));
    }
    
    private static string GetOverrideTarget(Context context, ActorsTask.ActorHierarchy ancestor)
        => ancestor.HasAncestors
            ? $"{ancestor.ActorInfo.Actor}.{context.Path.FormatRelative()}"
            : $"{ancestor.ActorInfo.FormattedLinkType}.Indexable";

    private static ILinkImplmenter.LinkSpec CreateInterfaceSpec(Context context, CancellationToken token)
    {
        var redefinesLinkMembers = context.AncestorInfos.Count > 0 || !context.ActorInfo.IsCore;

        var spec = new ILinkImplmenter.LinkSpec(
            Indexers: new([
                new IndexerSpec(
                    Type: context.ActorInfo.Actor.DisplayString,
                    Modifiers: new(redefinesLinkMembers ? ["new"] : []),
                    Accessibility: Accessibility.Internal,
                    Parameters: new([
                        (context.ActorInfo.FormattedIdentifiable, "identity")
                    ]),
                    Expression: "identity.Actor ?? GetActor(identity.Id)"
                )
            ])
        );

        if (!context.ActorInfo.IsCore)
        {
            spec = spec with
            {
                Indexers = spec.Indexers.AddRange(
                    new IndexerSpec(
                        Type: context.ActorInfo.CoreActor.DisplayString,
                        Parameters: new([
                            (context.ActorInfo.FormattedIdentifiable, "identity")
                        ]),
                        Expression: "identity.Actor ?? GetActor(identity.Id)",
                        ExplicitInterfaceImplementation: $"{context.ActorInfo.CoreActor}.Indexable"
                    ),
                    new IndexerSpec(
                        Type: context.ActorInfo.CoreActor.DisplayString,
                        Parameters: new([
                            (context.ActorInfo.Id.DisplayString, "id")
                        ]),
                        Expression: "this[id]",
                        ExplicitInterfaceImplementation: $"{context.ActorInfo.FormattedCoreLinkType}.Indexable"
                    )
                ),
                Methods = spec.Methods.AddRange(
                    new MethodSpec(
                        Name: "Specifically",
                        ReturnType: context.ActorInfo.Actor.DisplayString,
                        ExplicitInterfaceImplementation: $"{context.ActorInfo.FormattedCoreLinkType}.Indexable",
                        Parameters: new([
                            (context.ActorInfo.Id.DisplayString, "id")
                        ]),
                        Expression: "Specifically(id)"
                    )
                )
            };
        }

        if (!redefinesLinkMembers)
            return spec;

        return spec with
        {
            Indexers = spec.Indexers.AddRange([
                new IndexerSpec(
                    Type: context.ActorInfo.Actor.DisplayString,
                    Modifiers: new(["new"]),
                    Parameters: new([
                        (context.ActorInfo.Id.DisplayString, "id")
                    ]),
                    Expression: $"(this as {context.ActorInfo.FormattedActorProvider}).GetActor(id)"
                ),
                ..context.Ancestors.Select(x =>
                    new IndexerSpec(
                        Type: x.ActorInfo.Actor.DisplayString,
                        Parameters: new([
                            (context.ActorInfo.Id.DisplayString, "id")
                        ]),
                        ExplicitInterfaceImplementation: GetOverrideTarget(context, x),
                        Expression: "this[id]"
                    )
                )
            ]),
            Methods = spec.Methods.AddRange([
                new MethodSpec(
                    Name: "Specifically",
                    ReturnType: context.ActorInfo.Actor.DisplayString,
                    Modifiers: new(["new"]),
                    Parameters: new([
                        (context.ActorInfo.Id.DisplayString, "id")
                    ]),
                    Expression: $"(this as {context.ActorInfo.FormattedActorProvider}).GetActor(id)"
                ),
                ..context.Ancestors.Select(x =>
                    new MethodSpec(
                        Name: "Specifically",
                        ReturnType: x.ActorInfo.Actor.DisplayString,
                        Parameters: new([
                            (context.ActorInfo.Id.DisplayString, "id")
                        ]),
                        ExplicitInterfaceImplementation: GetOverrideTarget(context, x),
                        Expression: "Specifically(id)"
                    )
                )
            ])
        };
    }

    // public IndexableNode(IncrementalGeneratorInitializationContext context, Logger logger) : base(context, logger)
    // {
    // }
    //
    // protected override bool ShouldContinue(LinkTypeNode.State linkState, CancellationToken token)
    //     => linkState.Entry.Type.Name == "Indexable" && linkState.IsTemplate;
    //
    // protected override IncrementalValuesProvider<Branch<ILinkImplmenter.LinkImplementation>> CreateImplementation(
    //     IncrementalValuesProvider<Branch<LinkInfo>> provider
    // ) => provider.Select(Build);
    //
    // private ILinkImplmenter.LinkImplementation Build(LinkInfo state, CancellationToken token)
    // {
    //     using var logger = Logger
    //         .GetSubLogger(state.ActorInfo.Assembly.ToString())
    //         .GetSubLogger(nameof(Build))
    //         .GetSubLogger(state.ActorInfo.Actor.MetadataName);
    //     
    //     logger.Log("Building indexable link");
    //     logger.Log($" - {state.ActorInfo.Actor.DisplayString}");
    //     
    //     return new ILinkImplmenter.LinkImplementation(
    //         CreateInterfaceSpec(state, token),
    //         CreateImplementationSpec(state, token)
    //     );
    // }
    //
    // private static string GetOverrideTarget(LinkInfo info, AncestorInfo ancestor)
    //     => ancestor.HasAncestors
    //         ? $"{ancestor.ActorInfo.Actor}.{info.State.Path.FormatRelative()}"
    //         : $"{ancestor.ActorInfo.FormattedLinkType}.Indexable";
    //

    // }
    //
    // private static ILinkImplmenter.LinkSpec CreateImplementationSpec(LinkInfo info, CancellationToken token)
    // {
    //     return ILinkImplmenter.LinkSpec.Empty;
    // }
}