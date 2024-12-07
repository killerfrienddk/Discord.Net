using Discord;

namespace Discord;

public partial interface IPublicThreadChannelActor
{
    new Discord.IThreadMemberActor.Enumerable.Indexable.WithCurrentMember.WithPagedVariant.BackLink<Discord.IPublicThreadChannelActor> Members { get; }

    Discord.IThreadMemberActor.Enumerable.Indexable.WithCurrentMember.WithPagedVariant.BackLink<Discord.IThreadChannelActor> Discord.IThreadChannelActor.Members => Members;
}
