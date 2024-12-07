using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IMemberActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IMemberActor, ulong, Discord.IMember>
    {
        Discord.IMemberActor Member { get; }
    
        Discord.IMemberActor Discord.IRelationship<Discord.IMemberActor, ulong, Discord.IMember>.RelationshipActor => Member;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IMemberActor, ulong, Discord.IMember>,
        Discord.IUserActor.CanonicalRelationship
    {
        new Discord.IGuildActor Guild => Member.Guild;
    
        Discord.IUserActor Discord.IUserActor.Relationship.User => Member;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
