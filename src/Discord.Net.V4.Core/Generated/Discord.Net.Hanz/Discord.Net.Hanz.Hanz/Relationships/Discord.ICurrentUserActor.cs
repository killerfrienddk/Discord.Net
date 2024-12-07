using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface ICurrentUserActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.ICurrentUserActor, ulong, Discord.ICurrentUser>
    {
        Discord.ICurrentUserActor CurrentUser { get; }
    
        Discord.ICurrentUserActor Discord.IRelationship<Discord.ICurrentUserActor, ulong, Discord.ICurrentUser>.RelationshipActor => CurrentUser;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.ICurrentUserActor, ulong, Discord.ICurrentUser>,
        Discord.IUserActor.CanonicalRelationship
    {
        Discord.IUserActor Discord.IUserActor.Relationship.User => CurrentUser;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
