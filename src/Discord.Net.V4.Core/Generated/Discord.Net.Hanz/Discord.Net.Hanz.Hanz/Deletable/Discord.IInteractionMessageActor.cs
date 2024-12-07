namespace Discord;

public partial interface IInteractionMessageActor : 
    Discord.IDeletable<ulong, Discord.IInteractionMessageActor>
{
    static IApiRoute Discord.IDeletable<ulong, Discord.IInteractionMessageActor>.DeleteRoute(IPathable path, ulong id) => Discord.Rest.Routes.DeleteFollowupMessage(id, path.Require<Discord.ITokenPathProvider>(), id);
}
