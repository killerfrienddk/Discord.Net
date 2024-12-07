namespace Discord;

public partial interface IGuildActor : 
    Discord.IDeletable<ulong, Discord.IGuildActor>
{
    static IApiRoute Discord.IDeletable<ulong, Discord.IGuildActor>.DeleteRoute(IPathable path, ulong id) => Discord.Rest.Routes.DeleteGuild(id);
}
