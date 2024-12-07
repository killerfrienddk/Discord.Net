using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IPublicThreadChannelActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IPublicThreadChannelActor, ulong, Discord.IPublicThreadChannel>
    {
        Discord.IPublicThreadChannelActor Thread { get; }
    
        Discord.IPublicThreadChannelActor Discord.IRelationship<Discord.IPublicThreadChannelActor, ulong, Discord.IPublicThreadChannel>.RelationshipActor => Thread;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IPublicThreadChannelActor, ulong, Discord.IPublicThreadChannel>,
        Discord.IThreadChannelActor.CanonicalRelationship,
        Discord.IChannelActor.CanonicalRelationship
    {
        internal new Discord.IPublicThreadChannelActor Thread { get; }
    
        Discord.IThreadChannelActor Discord.IThreadChannelActor.Relationship.Thread => Thread;
        Discord.IChannelActor Discord.IChannelActor.Relationship.Channel => Thread;
        Discord.IPublicThreadChannelActor Discord.IPublicThreadChannelActor.Relationship.Thread => Thread;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
