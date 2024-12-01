using Discord.Net.Hanz.Nodes;
using Discord.Net.Hanz.Nodes.TypeNodes;
using Discord.Net.Hanz.Tasks.Actors.Common;
using Microsoft.CodeAnalysis;

namespace Discord.Net.Hanz.Tasks.Actors.Links.Nodes;

public abstract class LinkNode : Node
{
    protected IncrementalValuesProvider<LinkSchematics.Schematic> Schematics { get; }

    protected LinkNode(
        IncrementalGeneratorInitializationContext context,
        Logger logger
    ) : base(context, logger)
    {
        Schematics = GetTask<LinkSchematics>(context).Schematics;
    }

    protected IncrementalValuesProvider<IntrospectionResult<AncestorPathingIntrospection, TState>>
        Introspect<TState>(
            IncrementalValuesProvider<IntrospectionContext<TState>> provider,
            Func<TState, ActorInfo> getActorInfo
        ) => provider
        .KeyedBy(x => getActorInfo(x.State))
        .JoinByKey(GetTask<ActorsTask>().ActorAncestors)
        .Select((info, pair) =>
            new IntrospectionResult<AncestorPathingIntrospection, TState>(
                pair.Value.State,
                AncestorPathingIntrospection.Introspect(
                    info,
                    pair.Other,
                    pair.Value.Path,
                    pair.Value.Graph
                ),
                pair.Value.Path
            )
        );
}