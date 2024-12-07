using Discord;

namespace Discord;

public partial interface IPrivateThreadChannelActor
{
    new Discord.IThreadMemberActor.Enumerable.Indexable.WithCurrentMember.WithPagedVariant.BackLink<Discord.IPrivateThreadChannelActor> Members { get; }

    Discord.IThreadMemberActor.Enumerable.Indexable.WithCurrentMember.WithPagedVariant.BackLink<Discord.IThreadChannelActor> Discord.IThreadChannelActor.Members => Members;
}
