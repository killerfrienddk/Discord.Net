namespace Discord;

public partial interface IGlobalApplicationCommandActor : 
    Discord.IDeletable<ulong, Discord.IGlobalApplicationCommandActor>
{
    static IApiRoute Discord.IDeletable<ulong, Discord.IGlobalApplicationCommandActor>.DeleteRoute(IPathable path, ulong id) => Discord.Rest.Routes.DeleteGlobalApplicationCommand(id, id);
}
