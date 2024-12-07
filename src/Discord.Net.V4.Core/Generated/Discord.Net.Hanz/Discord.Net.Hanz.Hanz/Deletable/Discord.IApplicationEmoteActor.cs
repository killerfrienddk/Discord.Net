namespace Discord;

public partial interface IApplicationEmoteActor : 
    Discord.IDeletable<ulong, Discord.IApplicationEmoteActor>
{
    static IApiRoute Discord.IDeletable<ulong, Discord.IApplicationEmoteActor>.DeleteRoute(IPathable path, ulong id) => Discord.Rest.Routes.DeleteApplicationEmoji(id, id);
}
