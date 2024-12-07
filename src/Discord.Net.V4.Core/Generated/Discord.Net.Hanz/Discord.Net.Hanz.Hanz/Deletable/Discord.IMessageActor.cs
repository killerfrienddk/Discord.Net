namespace Discord;

public partial interface IMessageActor : 
    Discord.IDeletable<ulong, Discord.IMessageActor>
{
    static IApiRoute Discord.IDeletable<ulong, Discord.IMessageActor>.DeleteRoute(IPathable path, ulong id) => Discord.Rest.Routes.DeleteMessage(id, id);
}
