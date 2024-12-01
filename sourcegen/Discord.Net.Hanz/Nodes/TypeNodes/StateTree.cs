using Discord.Net.Hanz.Utils.Bakery;

namespace Discord.Net.Hanz.Nodes.TypeNodes;

public record StateTree(
    ITypeProducerNode Node,
    INodeGeneration Generation,
    ImmutableEquatableArray<StateTree> Children
)
{
    public virtual bool Equals(StateTree? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        return Generation.Equals(other.Generation) && Children.Equals(other.Children);
    }

    public override int GetHashCode()
    {
        return System.HashCode.Combine(Generation, Children);
    }
}