using Discord.Net.Hanz.Tasks.Actors;
using Microsoft.CodeAnalysis;

namespace Discord.Net.Hanz.Nodes;

public interface INestedNode<TState>
    where TState : IHasActorInfo
{
    IncrementalValuesProvider<Node.StatefulGeneration<TState>> From(
        IncrementalValuesProvider<Node.StatefulGeneration<TState>> provider
    );
}

public interface INestedNode
{
    IncrementalValuesProvider<Node.StatefulGeneration<TState>> From<TState>(
        IncrementalValuesProvider<Node.StatefulGeneration<TState>> provider
    ) where TState : IHasActorInfo;
}