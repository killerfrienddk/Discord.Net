using System.Collections.Immutable;
using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;

namespace Discord.Net.Hanz.Nodes;

public interface INestedTypeProducerNode<TParameters>
{
    IncrementalValuesProvider<Branch<TypeSpec>> Create<TSource>(
        IncrementalValuesProvider<Branch<(TParameters Parameters, TSource Source)>> provider
    );
}