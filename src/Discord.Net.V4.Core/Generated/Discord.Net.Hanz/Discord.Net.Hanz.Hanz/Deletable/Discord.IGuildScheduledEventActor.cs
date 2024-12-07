namespace Discord;

public partial interface IGuildScheduledEventActor : 
    Discord.IDeletable<ulong, Discord.IGuildScheduledEventActor>
{
    static IApiRoute Discord.IDeletable<ulong, Discord.IGuildScheduledEventActor>.DeleteRoute(IPathable path, ulong id) => Discord.Rest.Routes.DeleteGuildScheduledEvent(id, id);
}
