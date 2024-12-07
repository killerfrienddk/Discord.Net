using Discord.Models;

namespace Discord;

public partial interface IHasThreadsTrait<out TThreadLink>
    where TThreadLink : class, ThreadChannelLinkType.Indexable
{
    ThreadChannelLinkType.Indexable IHasThreadsTrait.Threads => Threads;
}
