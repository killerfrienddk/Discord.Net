namespace Discord;

public partial interface IGuildApplicationCommandActor : 
    Discord.IDeletable<ulong, Discord.IGuildApplicationCommandActor>
{
    static IApiRoute Discord.IDeletable<ulong, Discord.IGuildApplicationCommandActor>.DeleteRoute(IPathable path, ulong id) => Discord.Rest.Routes.DeleteGuildApplicationCommand(id, id, id);
}
