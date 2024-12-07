using Discord;

namespace Discord;

public partial interface ICurrentMemberActor
{
    new Discord.IRoleActor.Indexable.BackLink<Discord.ICurrentMemberActor> Roles { get; }

    Discord.IRoleActor.Indexable.BackLink<Discord.IMemberActor> Discord.IMemberActor.Roles => Roles;
}
