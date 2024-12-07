namespace Discord;

public partial interface IGuildTemplateFromGuildActor : 
    Discord.IDeletable<string, Discord.IGuildTemplateFromGuildActor>
{
    static IApiRoute Discord.IDeletable<string, Discord.IGuildTemplateFromGuildActor>.DeleteRoute(IPathable path, string id) => Discord.Rest.Routes.DeleteGuildTemplate(path.Require<Discord.IGuild>(), id);
}
