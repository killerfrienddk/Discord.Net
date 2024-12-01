using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;

namespace Discord.Net.Hanz.Nodes.TypeNodes.Implementers;

public record NodeImplementation<TState, TParent>(
    TState State,
    TypePath Path,
    TParent Parent
);

public interface ICommonTypeImplementerNode;

public interface ITypeImplementerNode : ICommonTypeImplementerNode
{
    public interface WithState<TState> : ICommonTypeImplementerNode
    {
        IncrementalValuesProvider<NodeImplementation<TState, TParent>> Create<TParent>(
            IncrementalValuesProvider<NodeContext<TParent>> provider
        );
        
        void Implement(ref TypeSpec spec, TState state, TypePath path);
        
    }
    
    void Implement<TParent>(ref TypeSpec spec, TParent parent, TypePath path);
}