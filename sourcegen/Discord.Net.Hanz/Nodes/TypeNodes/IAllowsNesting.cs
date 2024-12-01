namespace Discord.Net.Hanz.Nodes.TypeNodes;

public interface IAllowsNesting<TState>
{
    public void AddChild<TChildState, TChildParameters, TIntrospection>(
        ITypeProducerNode<TChildState>.WithParameters<TChildParameters>.Introspects<TIntrospection> node,
        Func<TState, TChildParameters> parameterMapper
    );

    public void AddChild<TChildState, TChildParameters>(
        ITypeProducerNode<TChildState>.WithParameters<TChildParameters> node,
        Func<TState, TChildParameters> parameterMapper);

    public void AddChild<TChildState, TIntrospection>(ITypeProducerNode<TChildState>.Introspects<TIntrospection> node);

    public void AddChild<TChildState>(ITypeProducerNode<TChildState> node);
}