namespace Discord;

public partial interface IThreadMemberActor : 
    Discord.IDeletable<ulong, Discord.IThreadMemberActor>
{
    static IApiRoute Discord.IDeletable<ulong, Discord.IThreadMemberActor>.DeleteRoute(IPathable path, ulong id) => Discord.Rest.Routes.RemoveThreadMember(id, id);
}
