namespace Discord;

public partial interface IDMChannelActor : 
    Discord.IDeletable<ulong, Discord.IDMChannelActor>
{
    static IApiRoute Discord.IDeletable<ulong, Discord.IDMChannelActor>.DeleteRoute(IPathable path, ulong id) => Discord.Rest.Routes.DeleteChannel(id);
}
