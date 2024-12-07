namespace Discord;

public partial interface IRoleActor : 
    Discord.IDeletable<ulong, Discord.IRoleActor>
{
    static IApiRoute Discord.IDeletable<ulong, Discord.IRoleActor>.DeleteRoute(IPathable path, ulong id) => Discord.Rest.Routes.DeleteGuildRole(id, id);
}
