using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IVoiceChannelActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IVoiceChannelActor, ulong, Discord.IVoiceChannel>
    {
        Discord.IVoiceChannelActor Channel { get; }
    
        Discord.IVoiceChannelActor Discord.IRelationship<Discord.IVoiceChannelActor, ulong, Discord.IVoiceChannel>.RelationshipActor => Channel;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IVoiceChannelActor, ulong, Discord.IVoiceChannel>,
        Discord.IGuildChannelActor.CanonicalRelationship,
        Discord.IChannelActor.CanonicalRelationship
    {
        internal new Discord.IVoiceChannelActor Channel { get; }
    
        Discord.IGuildChannelActor Discord.IGuildChannelActor.Relationship.Channel => Channel;
        Discord.IChannelActor Discord.IChannelActor.Relationship.Channel => Channel;
        Discord.IVoiceChannelActor Discord.IVoiceChannelActor.Relationship.Channel => Channel;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
