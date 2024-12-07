using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IForumChannelActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IForumChannelActor, ulong, Discord.IForumChannel>
    {
        Discord.IForumChannelActor Channel { get; }
    
        Discord.IForumChannelActor Discord.IRelationship<Discord.IForumChannelActor, ulong, Discord.IForumChannel>.RelationshipActor => Channel;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IForumChannelActor, ulong, Discord.IForumChannel>,
        Discord.IGuildChannelActor.CanonicalRelationship,
        Discord.IChannelActor.CanonicalRelationship
    {
        internal new Discord.IForumChannelActor Channel { get; }
    
        Discord.IGuildChannelActor Discord.IGuildChannelActor.Relationship.Channel => Channel;
        Discord.IChannelActor Discord.IChannelActor.Relationship.Channel => Channel;
        Discord.IForumChannelActor Discord.IForumChannelActor.Relationship.Channel => Channel;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
