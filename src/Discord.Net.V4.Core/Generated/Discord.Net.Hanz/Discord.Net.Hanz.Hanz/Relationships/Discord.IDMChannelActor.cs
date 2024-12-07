using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IDMChannelActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IDMChannelActor, ulong, Discord.IDMChannel>
    {
        Discord.IDMChannelActor Channel { get; }
    
        Discord.IDMChannelActor Discord.IRelationship<Discord.IDMChannelActor, ulong, Discord.IDMChannel>.RelationshipActor => Channel;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IDMChannelActor, ulong, Discord.IDMChannel>,
        Discord.IChannelActor.CanonicalRelationship
    {
        internal new Discord.IDMChannelActor Channel { get; }
    
        Discord.IChannelActor Discord.IChannelActor.Relationship.Channel => Channel;
        Discord.IDMChannelActor Discord.IDMChannelActor.Relationship.Channel => Channel;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
