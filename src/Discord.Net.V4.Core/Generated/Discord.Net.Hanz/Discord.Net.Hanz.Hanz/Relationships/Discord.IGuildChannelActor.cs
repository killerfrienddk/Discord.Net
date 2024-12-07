using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IGuildChannelActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IGuildChannelActor, ulong, Discord.IGuildChannel>
    {
        Discord.IGuildChannelActor Channel { get; }
    
        Discord.IGuildChannelActor Discord.IRelationship<Discord.IGuildChannelActor, ulong, Discord.IGuildChannel>.RelationshipActor => Channel;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IGuildChannelActor, ulong, Discord.IGuildChannel>,
        Discord.IChannelActor.CanonicalRelationship
    {
        internal new Discord.IGuildChannelActor Channel { get; }
    
        new Discord.IGuildActor Guild => Channel.Guild;
    
        Discord.IChannelActor Discord.IChannelActor.Relationship.Channel => Channel;
        Discord.IGuildChannelActor Discord.IGuildChannelActor.Relationship.Channel => Channel;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
