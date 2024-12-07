using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IChannelActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IChannelActor, ulong, Discord.IChannel>
    {
        Discord.IChannelActor Channel { get; }
    
        Discord.IChannelActor Discord.IRelationship<Discord.IChannelActor, ulong, Discord.IChannel>.RelationshipActor => Channel;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IChannelActor, ulong, Discord.IChannel>;
}
#pragma warning restore CS0108
#pragma warning restore CS0109
