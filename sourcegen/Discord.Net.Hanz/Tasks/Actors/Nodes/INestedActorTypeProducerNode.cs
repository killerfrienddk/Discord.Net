using Discord.Net.Hanz.Nodes;
using Discord.Net.Hanz.Tasks.Actors;
using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;

namespace Discord.Net.Hanz.Tasks.Actors.Nodes;

public readonly record struct NestedTypeProducerContext(
    ActorInfo ActorInfo,
    TypePath Path
);

public interface INestedTypeProducerNode : INestedTypeProducerNode<NestedTypeProducerContext>;
