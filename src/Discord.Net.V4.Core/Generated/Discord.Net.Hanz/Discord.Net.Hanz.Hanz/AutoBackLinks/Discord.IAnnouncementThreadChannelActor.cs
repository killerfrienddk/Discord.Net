using Discord;

namespace Discord;

public partial interface IAnnouncementThreadChannelActor
{
    new Discord.IThreadMemberActor.Enumerable.Indexable.WithCurrentMember.WithPagedVariant.BackLink<Discord.IAnnouncementThreadChannelActor> Members { get; }

    Discord.IThreadMemberActor.Enumerable.Indexable.WithCurrentMember.WithPagedVariant.BackLink<Discord.IThreadChannelActor> Discord.IThreadChannelActor.Members => Members;
}
