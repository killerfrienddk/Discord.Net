using Microsoft.CodeAnalysis;

namespace Discord.Net.Hanz.Nodes.TypeNodes.Implementers;

public interface INodeImplementerInfo
{
    IncrementalValuesProvider<StatefulPathedTypeSpec<TParent>> ApplyImplementation<TParent>(
        IncrementalValuesProvider<StatefulPathedTypeSpec<TParent>> provider
    );
}

public sealed class StatefulNodeImplementerInfo<TState> : INodeImplementerInfo
{
    private readonly ITypeImplementerNode.WithState<TState> _node;

    public StatefulNodeImplementerInfo(
        ITypeImplementerNode.WithState<TState> node
    )
    {
        _node = node;
    }

    public IncrementalValuesProvider<StatefulPathedTypeSpec<TParent>> ApplyImplementation<TParent>(
        IncrementalValuesProvider<StatefulPathedTypeSpec<TParent>> provider)
    {
        return _node
            .Create(
                provider.Select((x, _) => new NodeContext<TParent>(x.Path, x.State))
            )
            .KeyedBy(x => (x.Parent, x.Path))
            .MergeByKey(
                provider.KeyedBy(x => (x.State, x.Path)),
                (_, result, original) =>
                {
                    if (!original.HasValue)
                        return default;

                    var statefulSpec = original.Value;

                    if (result.HasValue)
                    {
                        var spec = statefulSpec.Spec;
                        _node.Implement(ref spec, result.Value.State, statefulSpec.Path);
                        return (statefulSpec with {Spec = spec}).Some();
                    }

                    return statefulSpec.Some();
                }
            )
            .ValuesProvider;

        // return 
        //     .
        //     .MapValuesVia(
        //         keyed,
        //         (state, implementation, statefulSpec) =>
        //         {
        //             var spec = statefulSpec.Spec;
        //             _node.Implement(ref spec, implementation.State, statefulSpec.Path);
        //             return statefulSpec with {Spec = spec};
        //         }
        //     )
        //     .ValuesProvider;
    }
}

public sealed class BasicNodeImplementerInfo : INodeImplementerInfo
{
    private readonly ITypeImplementerNode _node;

    public BasicNodeImplementerInfo(ITypeImplementerNode node)
    {
        _node = node;
    }

    public IncrementalValuesProvider<StatefulPathedTypeSpec<TParent>> ApplyImplementation<TParent>(
        IncrementalValuesProvider<StatefulPathedTypeSpec<TParent>> provider)
    {
        return provider
            .Select((statefulSpec, _) =>
            {
                var spec = statefulSpec.Spec;
                _node.Implement(ref spec, statefulSpec.State, statefulSpec.Path);
                return statefulSpec with {Spec = spec};
            });
    }
}