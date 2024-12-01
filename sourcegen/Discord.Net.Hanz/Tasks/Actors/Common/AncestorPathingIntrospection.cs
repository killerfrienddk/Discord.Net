using Discord.Net.Hanz.Nodes.TypeNodes;
using Discord.Net.Hanz.Tasks.Actors.Links.Nodes.Modifiers;
using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;

namespace Discord.Net.Hanz.Tasks.Actors.Common;

public sealed record AncestorPathingIntrospection(
    ImmutableEquatableArray<TypePath> SemanticBases,
    ImmutableEquatableArray<ActorInfo> AncestorBases
)
{
    // public static IncrementalValuesProvider<IntrospectionResult<AncestorPathingIntrospection, TState>>
    //     Introspect<TState>(
    //         IncrementalValuesProvider<IntrospectionContext<TState>> provider,
    //         Func<TState, ActorInfo> getActorInfo
    //     )
    // {
    //     
    // }
    
    public static AncestorPathingIntrospection Introspect(
        ActorInfo actorInfo, 
        ImmutableEquatableArray<AncestorInfo> ancestors,
        TypePath path,
        IIntrospectionGraph graph)
    {
        if (!graph.TryGet(actorInfo, out var introspection))
            return null;

        var semantics = (~path).SemanticalProduct().ToArray();
        var targets = (path.First.Value + semantics).ToArray();

        return new AncestorPathingIntrospection(
            targets.Where(introspection.Contains).ToImmutableEquatableArray(),
            ancestors
                .Select(x => x.ActorInfo)
                .Where(x => graph.TryGet(x, out var tree) && tree.HasSubPath(~path))
                .ToImmutableEquatableArray()
        );
    }
}