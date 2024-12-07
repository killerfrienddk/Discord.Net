namespace Discord;

public partial interface IBanActor : 
    Discord.IDeletable<ulong, Discord.IBanActor>
{
    static IApiRoute Discord.IDeletable<ulong, Discord.IBanActor>.DeleteRoute(IPathable path, ulong id) => Discord.Rest.Routes.RemoveGuildBan(id, id);
}
