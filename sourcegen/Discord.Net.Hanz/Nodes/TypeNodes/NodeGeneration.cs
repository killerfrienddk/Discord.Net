using Discord.Net.Hanz.Utils.Bakery;

namespace Discord.Net.Hanz.Nodes.TypeNodes;

public record NodeGeneration<TState>(
    TState State,
    TypePath Path,
    ImmutableEquatableArray<INodeGeneration> Children
) : INodeGeneration
{
    public bool Equals(INodeGeneration other)
        => other is NodeGeneration<TState> nodeGeneration && Equals(nodeGeneration);

    public object? GetState() => State;
}

public record NodeGeneration<TState, TParent>(
    TState State,
    TypePath Path,
    TParent Parent,
    ImmutableEquatableArray<INodeGeneration> Children
) : NodeGeneration<TState>(State, Path, Children);

public interface INodeGeneration : IEquatable<INodeGeneration>
{
    TypePath Path { get; }
    ImmutableEquatableArray<INodeGeneration> Children { get; }

    object? GetState();
}