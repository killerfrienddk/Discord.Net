using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IInviteActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IInviteActor, string, Discord.IInvite>
    {
        Discord.IInviteActor Invite { get; }
    
        Discord.IInviteActor Discord.IRelationship<Discord.IInviteActor, string, Discord.IInvite>.RelationshipActor => Invite;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IInviteActor, string, Discord.IInvite>;
}
#pragma warning restore CS0108
#pragma warning restore CS0109
