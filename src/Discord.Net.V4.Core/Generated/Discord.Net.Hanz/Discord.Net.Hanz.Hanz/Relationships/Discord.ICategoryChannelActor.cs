using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface ICategoryChannelActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.ICategoryChannelActor, ulong, Discord.ICategoryChannel>
    {
        Discord.ICategoryChannelActor Channel { get; }
    
        Discord.ICategoryChannelActor Discord.IRelationship<Discord.ICategoryChannelActor, ulong, Discord.ICategoryChannel>.RelationshipActor => Channel;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.ICategoryChannelActor, ulong, Discord.ICategoryChannel>,
        Discord.IGuildChannelActor.CanonicalRelationship,
        Discord.IChannelActor.CanonicalRelationship
    {
        internal new Discord.ICategoryChannelActor Channel { get; }
    
        Discord.IGuildChannelActor Discord.IGuildChannelActor.Relationship.Channel => Channel;
        Discord.IChannelActor Discord.IChannelActor.Relationship.Channel => Channel;
        Discord.ICategoryChannelActor Discord.ICategoryChannelActor.Relationship.Channel => Channel;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
