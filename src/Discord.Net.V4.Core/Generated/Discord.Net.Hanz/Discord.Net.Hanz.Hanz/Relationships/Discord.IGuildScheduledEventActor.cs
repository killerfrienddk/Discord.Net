using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IGuildScheduledEventActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IGuildScheduledEventActor, ulong, Discord.IGuildScheduledEvent>
    {
        Discord.IGuildScheduledEventActor GuildScheduledEvent { get; }
    
        Discord.IGuildScheduledEventActor Discord.IRelationship<Discord.IGuildScheduledEventActor, ulong, Discord.IGuildScheduledEvent>.RelationshipActor => GuildScheduledEvent;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IGuildScheduledEventActor, ulong, Discord.IGuildScheduledEvent>
    {
        new Discord.IGuildActor Guild => GuildScheduledEvent.Guild;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
