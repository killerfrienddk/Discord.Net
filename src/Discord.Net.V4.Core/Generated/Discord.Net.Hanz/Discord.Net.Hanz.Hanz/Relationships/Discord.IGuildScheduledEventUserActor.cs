using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IGuildScheduledEventUserActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IGuildScheduledEventUserActor, ulong, Discord.IGuildScheduledEventUser>
    {
        Discord.IGuildScheduledEventUserActor GuildScheduledEventUser { get; }
    
        Discord.IGuildScheduledEventUserActor Discord.IRelationship<Discord.IGuildScheduledEventUserActor, ulong, Discord.IGuildScheduledEventUser>.RelationshipActor => GuildScheduledEventUser;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IGuildScheduledEventUserActor, ulong, Discord.IGuildScheduledEventUser>
    {
        new Discord.IMemberActor Member => GuildScheduledEventUser.Member;
    
        new Discord.IGuildScheduledEventActor GuildScheduledEvent => GuildScheduledEventUser.GuildScheduledEvent;
    
        new Discord.IGuildActor Guild => GuildScheduledEventUser.Member.Guild;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
