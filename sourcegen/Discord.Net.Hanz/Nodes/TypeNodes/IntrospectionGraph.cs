using System.Collections.Immutable;

namespace Discord.Net.Hanz.Nodes.TypeNodes;

public interface IIntrospectionGraph
{
    bool Contains<TSource>(TSource source);
    bool TryGet<TSource>(TSource source, out IntrospectionSourceTree<TSource> tree);
}

public sealed class IntrospectionGraph<TSource> : IIntrospectionGraph
{
    public ImmutableArray<IntrospectionSourceTree<TSource>> Trees { get; }

    public IntrospectionGraph(ImmutableArray<IntrospectionSourceTree<TSource>> trees)
    {
        Trees = trees;
    }

    public bool Contains<T>(T source)
    {
        if (source is not TSource actual)
            return false;

        return Trees.Any(x => EqualityComparer<TSource>.Default.Equals(actual, x.Source));
    }

    public bool TryGet<T>(T source, out IntrospectionSourceTree<T> tree)
    {
        if (source is not TSource actual)
        {
            tree = default!;
            return false;
            
        }

        tree = Trees
                .FirstOrDefault(x => EqualityComparer<TSource>.Default.Equals(x.Source, actual))
            as IntrospectionSourceTree<T>;

        return tree is not null;
    }
}

public sealed class IntrospectionSourceTree<TSource> : IEquatable<IntrospectionSourceTree<TSource>>
{
    public TSource Source { get; }
    public ImmutableArray<StateTree> Trees { get; }
    
    public IntrospectionSourceTree(TSource source, ImmutableArray<StateTree> trees)
    {
        Source = source;
        Trees = trees;
    }

    public bool HasSubPath(TypePath path)
    {
        return TryMatchTo(
            other => other.Count == 1 || path.StartsWith(~other),
            x => ~x == path,
            out _
        );
    }

    public IEnumerable<INodeGeneration> Where(Func<TypePath, bool> predicate)
    {
        var queue = new Queue<StateTree>(Trees);

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();
            
            if(predicate(current.Generation.Path))
                yield return current.Generation;

            foreach (var child in current.Children)
                queue.Enqueue(child);
        }
    }
    
    public bool Contains(TypePath path) => TryTraverse(path, out _);

    public bool TryGetState<TState>(TypePath path, out TState state)
    {
        state = default;

        if (!TryTraverse(path, out var generation))
        {
            return false;
        }

        if (generation is not NodeGeneration<TState> stateful)
            return false;

        state = stateful.State;
        return true;
    }

    private bool TryTraverse(TypePath path, out INodeGeneration generation)
        => TryMatchTo(x => path.StartsWith(x), x => x == path, out generation);

    private bool TryMatchTo(
        Func<TypePath, bool> shouldContinue,
        Func<TypePath, bool> isResult,
        out INodeGeneration generation
    )
    {
        var queue = new Queue<StateTree>(Trees);

        while (queue.Count > 0)
        {
            var (_, nodeGeneration, children) = queue.Dequeue();

            if (isResult(nodeGeneration.Path))
            {
                generation = nodeGeneration;
                return true;
            }
            
            if(!shouldContinue(nodeGeneration.Path))
                continue;

            foreach (var child in children)
            {
                if (isResult(child.Generation.Path))
                {
                    generation = child.Generation;
                    return true;
                }
                
                if(!shouldContinue(child.Generation.Path))
                    continue;
                
                queue.Enqueue(child);
            }
        }

        generation = default!;
        return false;
    }
    
    public bool Equals(IntrospectionSourceTree<TSource>? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        return EqualityComparer<TSource>.Default.Equals(Source, other.Source) && Trees.SequenceEqual(other.Trees);
    }

    public override bool Equals(object? obj)
    {
        return ReferenceEquals(this, obj) || obj is IntrospectionSourceTree<TSource> other && Equals(other);
    }

    public override int GetHashCode()
    {
        return System.HashCode.Combine(Source, Trees.Aggregate(0, System.HashCode.Combine));
    }

    public static bool operator ==(IntrospectionSourceTree<TSource>? left, IntrospectionSourceTree<TSource>? right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(IntrospectionSourceTree<TSource>? left, IntrospectionSourceTree<TSource>? right)
    {
        return !Equals(left, right);
    }
}