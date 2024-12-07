namespace Discord;

public partial interface IGuildInviteActor : 
    Discord.IDeletable<string, Discord.IGuildInviteActor>
{
    static IApiRoute Discord.IDeletable<string, Discord.IGuildInviteActor>.DeleteRoute(IPathable path, string id) => Discord.Rest.Routes.DeleteInvite(id);
}
