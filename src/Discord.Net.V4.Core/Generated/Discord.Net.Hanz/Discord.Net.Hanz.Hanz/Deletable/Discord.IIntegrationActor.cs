namespace Discord;

public partial interface IIntegrationActor : 
    Discord.IDeletable<ulong, Discord.IIntegrationActor>
{
    static IApiRoute Discord.IDeletable<ulong, Discord.IIntegrationActor>.DeleteRoute(IPathable path, ulong id) => Discord.Rest.Routes.DeleteGuildIntegration(id, id);
}
