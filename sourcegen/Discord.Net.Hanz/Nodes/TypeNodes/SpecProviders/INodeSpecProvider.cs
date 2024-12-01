using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;

namespace Discord.Net.Hanz.Nodes.TypeNodes;

public interface INodeSpecProvider<TParent, TState>
{
    IncrementalGroupingProvider<TParent, StatefulPathedTypeSpec<TState>> GetSpecProvider(
        NodeInfo<TParent, TState> nodeInfo,
        IncrementalValueProvider<IIntrospectionGraph> graph
    );
}

public sealed class SimpleSpecProvider<TParent, TState> : INodeSpecProvider<TParent, TState>
{
    private readonly IStatefulNode<TState> _node;

    public SimpleSpecProvider(IStatefulNode<TState> node)
    {
        _node = node;
    }

    public IncrementalGroupingProvider<TParent, StatefulPathedTypeSpec<TState>> GetSpecProvider(
        NodeInfo<TParent, TState> nodeInfo,
        IncrementalValueProvider<IIntrospectionGraph> graph
    ) => nodeInfo
        .Provider
        .GroupBy(x => (x.Parent, MapGeneration(x)));

    private StatefulPathedTypeSpec<TState> MapGeneration(
        NodeGeneration<TState> generation
    ) => new(
        generation.State,
        generation.Path,
        _node.CreateSpec(generation.State, generation.Path),
        generation.Children
            .OfType<NodeGeneration<TState>>()
            .Select(MapGeneration)
            .ToImmutableEquatableArray<PathedTypeSpec>()
    );
}

public sealed class IntrospectingSpecProvider<TParent, TState, TIntrospection> : INodeSpecProvider<TParent, TState>
{
    private readonly IIntrospectingNode<TIntrospection, TState> _node;

    public IntrospectingSpecProvider(IIntrospectingNode<TIntrospection, TState> node)
    {
        _node = node;
    }

    public IncrementalGroupingProvider<TParent, StatefulPathedTypeSpec<TState>> GetSpecProvider(
        NodeInfo<TParent, TState> nodeInfo,
        IncrementalValueProvider<IIntrospectionGraph> graph
    )
    {
        var introspection = _node
            .Introspect(
                nodeInfo
                    .Provider
                    .Combine(graph)
                    .SelectMany((pair, _) => CreateContexts(pair.Left, pair.Right))
            )
            .KeyedBy(x => (x.State, x.Path), x => x.Introspection);

        return nodeInfo
            .Provider
            .KeyedBy(x => (x.State, x.Path), x => x)
            .JoinByKey(
                introspection,
                (info, generation, introspection) => (Parent: generation.Parent, StatefulSpec: Map(generation))
            )
            .ValuesProvider
            .GroupBy(x => (x.Parent, x.StatefulSpec));

        StatefulPathedTypeSpec<TState> Map(NodeGeneration<TState> generation)
        {
            return new(
                generation.State,
                generation.Path,
                _node.CreateSpec(introspection.GetValue((generation.State, generation.Path)), generation.State,
                    generation.Path),
                generation.Children.OfType<NodeGeneration<TState>>().Select(Map).ToImmutableEquatableArray<PathedTypeSpec>()
            );
        }
    }

    private IEnumerable<IntrospectionContext<TState>> CreateContexts(
        NodeGeneration<TState> generation,
        IIntrospectionGraph graph
    )
    {
        yield return new(
            generation.State,
            generation.Path,
            graph
        );

        foreach (var child in generation.Children.OfType<NodeGeneration<TState>>())
        foreach (var childContext in CreateContexts(child, graph))
        {
            yield return childContext;
        }
    }
}