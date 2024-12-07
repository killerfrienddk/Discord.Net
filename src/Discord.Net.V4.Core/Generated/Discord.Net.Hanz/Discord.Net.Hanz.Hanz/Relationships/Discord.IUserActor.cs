using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IUserActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IUserActor, ulong, Discord.IUser>
    {
        Discord.IUserActor User { get; }
    
        Discord.IUserActor Discord.IRelationship<Discord.IUserActor, ulong, Discord.IUser>.RelationshipActor => User;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IUserActor, ulong, Discord.IUser>;
}
#pragma warning restore CS0108
#pragma warning restore CS0109
