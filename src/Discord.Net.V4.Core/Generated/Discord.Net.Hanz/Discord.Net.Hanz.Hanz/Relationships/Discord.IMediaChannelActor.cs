using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IMediaChannelActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IMediaChannelActor, ulong, Discord.IMediaChannel>
    {
        Discord.IMediaChannelActor Channel { get; }
    
        Discord.IMediaChannelActor Discord.IRelationship<Discord.IMediaChannelActor, ulong, Discord.IMediaChannel>.RelationshipActor => Channel;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IMediaChannelActor, ulong, Discord.IMediaChannel>,
        Discord.IGuildChannelActor.CanonicalRelationship,
        Discord.IChannelActor.CanonicalRelationship
    {
        internal new Discord.IMediaChannelActor Channel { get; }
    
        Discord.IGuildChannelActor Discord.IGuildChannelActor.Relationship.Channel => Channel;
        Discord.IChannelActor Discord.IChannelActor.Relationship.Channel => Channel;
        Discord.IMediaChannelActor Discord.IMediaChannelActor.Relationship.Channel => Channel;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
