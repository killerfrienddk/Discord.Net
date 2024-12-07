using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IStageChannelActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IStageChannelActor, ulong, Discord.IStageChannel>
    {
        Discord.IStageChannelActor Channel { get; }
    
        Discord.IStageChannelActor Discord.IRelationship<Discord.IStageChannelActor, ulong, Discord.IStageChannel>.RelationshipActor => Channel;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IStageChannelActor, ulong, Discord.IStageChannel>,
        Discord.IVoiceChannelActor.CanonicalRelationship,
        Discord.IGuildChannelActor.CanonicalRelationship,
        Discord.IChannelActor.CanonicalRelationship
    {
        internal new Discord.IStageChannelActor Channel { get; }
    
        Discord.IVoiceChannelActor Discord.IVoiceChannelActor.Relationship.Channel => Channel;
        Discord.IGuildChannelActor Discord.IGuildChannelActor.Relationship.Channel => Channel;
        Discord.IChannelActor Discord.IChannelActor.Relationship.Channel => Channel;
        Discord.IStageChannelActor Discord.IStageChannelActor.Relationship.Channel => Channel;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
