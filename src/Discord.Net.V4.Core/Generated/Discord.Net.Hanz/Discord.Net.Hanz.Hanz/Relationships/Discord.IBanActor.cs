using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IBanActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IBanActor, ulong, Discord.IBan>
    {
        Discord.IBanActor Ban { get; }
    
        Discord.IBanActor Discord.IRelationship<Discord.IBanActor, ulong, Discord.IBan>.RelationshipActor => Ban;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IBanActor, ulong, Discord.IBan>
    {
        new Discord.IUserActor User => Ban.User;
    
        new Discord.IGuildActor Guild => Ban.Guild;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
