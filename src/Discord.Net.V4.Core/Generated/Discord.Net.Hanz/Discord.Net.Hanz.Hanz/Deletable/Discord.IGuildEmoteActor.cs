namespace Discord;

public partial interface IGuildEmoteActor : 
    Discord.IDeletable<ulong, Discord.IGuildEmoteActor>
{
    static IApiRoute Discord.IDeletable<ulong, Discord.IGuildEmoteActor>.DeleteRoute(IPathable path, ulong id) => Discord.Rest.Routes.DeleteGuildEmoji(id, id);
}
