namespace Discord;

public partial interface IWebhookActor : 
    Discord.IDeletable<ulong, Discord.IWebhookActor>
{
    static IApiRoute Discord.IDeletable<ulong, Discord.IWebhookActor>.DeleteRoute(IPathable path, ulong id) => Discord.Rest.Routes.DeleteWebhook(id);
}
