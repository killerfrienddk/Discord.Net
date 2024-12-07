using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface ICurrentMemberActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.ICurrentMemberActor, ulong, Discord.ICurrentMember>
    {
        Discord.ICurrentMemberActor CurrentMember { get; }
    
        Discord.ICurrentMemberActor Discord.IRelationship<Discord.ICurrentMemberActor, ulong, Discord.ICurrentMember>.RelationshipActor => CurrentMember;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.ICurrentMemberActor, ulong, Discord.ICurrentMember>,
        Discord.IMemberActor.CanonicalRelationship,
        Discord.ICurrentUserActor.CanonicalRelationship,
        Discord.IUserActor.CanonicalRelationship
    {
        Discord.IMemberActor Discord.IMemberActor.Relationship.Member => CurrentMember;
        Discord.ICurrentUserActor Discord.ICurrentUserActor.Relationship.CurrentUser => CurrentMember;
        Discord.IUserActor Discord.IUserActor.Relationship.User => CurrentMember;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
