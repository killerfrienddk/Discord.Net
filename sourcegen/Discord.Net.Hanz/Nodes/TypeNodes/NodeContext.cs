using Discord.Net.Hanz.Utils.Bakery;

namespace Discord.Net.Hanz.Nodes.TypeNodes;

public record NodeContext<TParent, TParameters>(
    TypePath Path,
    TParent Parent,
    TParameters Parameters
) : NodeContext<TParent>(Path, Parent);

public record NodeContext<TParent>(
    TypePath Path,
    TParent Parent
)
{
    public NodeGeneration<TState, TParent> WithState<TState>(
        TState state,
        TypePath path,
        params INodeGeneration[] children
    ) => new(state, path, Parent, children.ToImmutableEquatableArray());
    public NodeGeneration<TState, TParent> WithState<TState>(
        TState state,
        TypePath path,
        IEnumerable<INodeGeneration> children
    ) => new(state, path, Parent, children.ToImmutableEquatableArray());
}