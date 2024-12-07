using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IThreadMemberActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IThreadMemberActor, ulong, Discord.IThreadMember>
    {
        Discord.IThreadMemberActor ThreadMember { get; }
    
        Discord.IThreadMemberActor Discord.IRelationship<Discord.IThreadMemberActor, ulong, Discord.IThreadMember>.RelationshipActor => ThreadMember;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IThreadMemberActor, ulong, Discord.IThreadMember>
    {
        new Discord.IUserActor User => ThreadMember.User;
    
        new Discord.IThreadChannelActor Thread => ThreadMember.Thread;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
