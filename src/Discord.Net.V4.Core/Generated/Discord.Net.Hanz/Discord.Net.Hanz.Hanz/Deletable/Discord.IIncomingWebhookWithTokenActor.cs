namespace Discord;

public partial interface IIncomingWebhookWithTokenActor : 
    Discord.IDeletable<ulong, Discord.IIncomingWebhookWithTokenActor>
{
    static IApiRoute Discord.IDeletable<ulong, Discord.IIncomingWebhookWithTokenActor>.DeleteRoute(IPathable path, ulong id) => Discord.Rest.Routes.DeleteWebhookWithToken(id, path.Require<Discord.ITokenPathProvider>());
}
