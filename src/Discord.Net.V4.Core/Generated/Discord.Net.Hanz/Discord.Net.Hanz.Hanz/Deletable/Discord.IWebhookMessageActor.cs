namespace Discord;

public partial interface IWebhookMessageActor : 
    Discord.IDeletable<ulong, Discord.IWebhookMessageActor>
{
    static IApiRoute Discord.IDeletable<ulong, Discord.IWebhookMessageActor>.DeleteRoute(IPathable path, ulong id) => Discord.Rest.Routes.DeleteWebhookMessage(id, path.Require<Discord.ITokenPathProvider>(), id, path.Require<Discord.IThreadChannel>());
}
