using Microsoft.CodeAnalysis;

namespace Discord.Net.Hanz.Nodes;

public interface IBranchNode<TIn, TOut>
{
    IncrementalValuesProvider<Branch<TOut>> Branch(
        IncrementalValuesProvider<Branch<TIn>> provider
    );
}