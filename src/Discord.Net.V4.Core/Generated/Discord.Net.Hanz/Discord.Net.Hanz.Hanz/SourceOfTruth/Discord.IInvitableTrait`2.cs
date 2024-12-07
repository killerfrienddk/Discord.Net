using Discord.Models;

namespace Discord;

public partial interface IInvitableTrait<out TInviteActor, out TInvite>
    where TInviteActor : class, Discord.IInviteActor, Discord.IActor<string, TInvite>
    where TInvite : class, Discord.IInvite
{
    Discord.IInviteActor IInvitableTrait.Invite(string code) => Invite(code);
}
