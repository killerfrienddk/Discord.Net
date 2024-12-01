using Microsoft.CodeAnalysis;

namespace Discord.Net.Hanz.Nodes.TypeNodes;

public class ProviderNesting<TState> : IAllowsNesting<TState>
{
    protected List<Func<IncrementalValuesProvider<(TState State, TypePath Path)>, NodeInfo<TState>>> Children { get; } =
        [];


    public void AddChild<TChildState, TIntrospection>(
        ITypeProducerNode<TChildState>.WithParameters<TState>.Introspects<TIntrospection> node
    ) => AddChild(node, x => x);
    
    public void AddChild<TChildState, TChildParameters, TIntrospection>(
        ITypeProducerNode<TChildState>.WithParameters<TChildParameters>.Introspects<TIntrospection> node,
        Func<TState, TChildParameters> parameterMapper
    ) => AddChild(
        (provider, context) => node.Create(
            provider.Select((x, _) => new NodeContext<TState, TChildParameters>(
                x.Path,
                x.State,
                parameterMapper(x.State)
            )),
            context
        ),
        new IntrospectingSpecProvider<TState, TChildState, TIntrospection>(node),
        node
    );

    public void AddChild<TChildState>(
        ITypeProducerNode<TChildState>.WithParameters<TState> node
    ) => AddChild(node, x => x);
    
    public void AddChild<TChildState, TChildParameters>(
        ITypeProducerNode<TChildState>.WithParameters<TChildParameters> node,
        Func<TState, TChildParameters> parameterMapper
    ) => AddChild(
        (provider, context) => node.Create<TState>(
            provider.Select((x, _) => new NodeContext<TState, TChildParameters>(
                x.Path,
                x.State,
                parameterMapper(x.State)
            )),
            context
        ),
        new SimpleSpecProvider<TState, TChildState>(node),
        node
    );

    public void AddChild<TChildState, TIntrospection>(ITypeProducerNode<TChildState>.Introspects<TIntrospection> node)
        => AddChild(
            (provider, context) => node.Create<TState>(
                provider.Select((x, _) => new NodeContext<TState>(
                    x.Path,
                    x.State
                )),
                context
            ),
            new IntrospectingSpecProvider<TState, TChildState, TIntrospection>(node),
            node
        );

    public void AddChild<TChildState>(ITypeProducerNode<TChildState> node)
        => AddChild(
            (provider, context) => node.Create<TState>(
                provider.Select((x, _) => new NodeContext<TState>(
                    x.Path,
                    x.State
                )),
                context
            ),
            new SimpleSpecProvider<TState, TChildState>(node),
            node
        );

    private void AddChild<TChildState>(
        Func<
            IncrementalValuesProvider<(TState State, TypePath Path)>,
            ContinuationContext<TChildState, TState>,
            IncrementalValuesProvider<NodeGeneration<TChildState, TState>>
        > providerFactory,
        INodeSpecProvider<TState, TChildState> specProvider,
        ITypeProducerNode node)
    {
        Children.Add(
            provider =>
            {
                var continuationContext = new ContinuationContext<TChildState, TState>();

                var childNode = new NodeInfo<TState, TChildState>(
                    node,
                    providerFactory(provider, continuationContext),
                    specProvider
                );

                continuationContext.Process(childNode);

                return childNode;
            });
    }
}