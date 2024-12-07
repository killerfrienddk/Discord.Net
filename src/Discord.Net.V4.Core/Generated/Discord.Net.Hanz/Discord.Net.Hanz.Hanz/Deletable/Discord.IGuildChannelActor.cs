namespace Discord;

public partial interface IGuildChannelActor : 
    Discord.IDeletable<ulong, Discord.IGuildChannelActor>
{
    static IApiRoute Discord.IDeletable<ulong, Discord.IGuildChannelActor>.DeleteRoute(IPathable path, ulong id) => Discord.Rest.Routes.DeleteChannel(id);
}
