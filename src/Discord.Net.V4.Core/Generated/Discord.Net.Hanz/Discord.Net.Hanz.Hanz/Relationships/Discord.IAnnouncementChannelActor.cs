using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IAnnouncementChannelActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IAnnouncementChannelActor, ulong, Discord.IAnnouncementChannel>
    {
        Discord.IAnnouncementChannelActor Channel { get; }
    
        Discord.IAnnouncementChannelActor Discord.IRelationship<Discord.IAnnouncementChannelActor, ulong, Discord.IAnnouncementChannel>.RelationshipActor => Channel;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IAnnouncementChannelActor, ulong, Discord.IAnnouncementChannel>,
        Discord.IGuildChannelActor.CanonicalRelationship,
        Discord.IChannelActor.CanonicalRelationship
    {
        internal new Discord.IAnnouncementChannelActor Channel { get; }
    
        Discord.IGuildChannelActor Discord.IGuildChannelActor.Relationship.Channel => Channel;
        Discord.IChannelActor Discord.IChannelActor.Relationship.Channel => Channel;
        Discord.IAnnouncementChannelActor Discord.IAnnouncementChannelActor.Relationship.Channel => Channel;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
