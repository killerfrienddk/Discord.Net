namespace Discord;

public partial interface IStageInstanceActor : 
    Discord.IDeletable<ulong, Discord.IStageInstanceActor>
{
    static IApiRoute Discord.IDeletable<ulong, Discord.IStageInstanceActor>.DeleteRoute(IPathable path, ulong id) => Discord.Rest.Routes.DeleteStageInstance(id);
}
