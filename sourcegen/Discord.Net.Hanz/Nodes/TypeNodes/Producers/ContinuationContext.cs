using Discord.Net.Hanz.Nodes.TypeNodes.Implementers;
using Microsoft.CodeAnalysis;

namespace Discord.Net.Hanz.Nodes.TypeNodes;

public class ContinuationContext<TState, TParent> :
    ProviderNesting<TState>
{
    private readonly List<INodeImplementerInfo> _implementers = [];

    public void WithImplementationFrom(
        ITypeImplementerNode node
    )
    {
        _implementers.Add(new BasicNodeImplementerInfo(node));
    }

    public void WithImplementationFrom<TState>(
        ITypeImplementerNode.WithState<TState> node
    )
    {
        _implementers.Add(new StatefulNodeImplementerInfo<TState>(node));
    }

    public void Process(NodeInfo<TParent, TState> info)
    {
        var childProvider = info.Provider.SelectMany(Expand);

        foreach (var child in Children)
        {
            info.AddChild(child(childProvider));
        }

        info.AddImplementers(_implementers);

        _implementers.Clear();
        Children.Clear();
    }

    private static IEnumerable<(TState, TypePath)> Expand(NodeGeneration<TState> generation, CancellationToken token)
    {
        yield return (generation.State, generation.Path);

        token.ThrowIfCancellationRequested();

        foreach (var child in generation.Children.OfType<NodeGeneration<TState>>())
        foreach (var childState in Expand(child, token))
        {
            token.ThrowIfCancellationRequested();
            yield return childState;
        }
    }
}