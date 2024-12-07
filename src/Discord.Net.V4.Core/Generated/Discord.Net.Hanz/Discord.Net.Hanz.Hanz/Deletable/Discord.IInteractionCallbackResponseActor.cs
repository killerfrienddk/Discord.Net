namespace Discord;

public partial interface IInteractionCallbackResponseActor : 
    Discord.IDeletable<ulong, Discord.IInteractionCallbackResponseActor>
{
    static IApiRoute Discord.IDeletable<ulong, Discord.IInteractionCallbackResponseActor>.DeleteRoute(IPathable path, ulong id) => Discord.Rest.Routes.DeleteOriginalInteractionResponse(id, path.Require<Discord.ITokenPathProvider>());
}
