using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IAnnouncementThreadChannelActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IAnnouncementThreadChannelActor, ulong, Discord.IAnnouncementThreadChannel>
    {
        Discord.IAnnouncementThreadChannelActor Thread { get; }
    
        Discord.IAnnouncementThreadChannelActor Discord.IRelationship<Discord.IAnnouncementThreadChannelActor, ulong, Discord.IAnnouncementThreadChannel>.RelationshipActor => Thread;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IAnnouncementThreadChannelActor, ulong, Discord.IAnnouncementThreadChannel>,
        Discord.IThreadChannelActor.CanonicalRelationship,
        Discord.IChannelActor.CanonicalRelationship
    {
        internal new Discord.IAnnouncementThreadChannelActor Thread { get; }
    
        Discord.IThreadChannelActor Discord.IThreadChannelActor.Relationship.Thread => Thread;
        Discord.IChannelActor Discord.IChannelActor.Relationship.Channel => Thread;
        Discord.IAnnouncementThreadChannelActor Discord.IAnnouncementThreadChannelActor.Relationship.Thread => Thread;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
