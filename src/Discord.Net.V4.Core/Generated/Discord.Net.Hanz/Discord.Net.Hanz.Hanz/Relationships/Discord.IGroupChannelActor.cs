using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IGroupChannelActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IGroupChannelActor, ulong, Discord.IGroupChannel>
    {
        Discord.IGroupChannelActor Channel { get; }
    
        Discord.IGroupChannelActor Discord.IRelationship<Discord.IGroupChannelActor, ulong, Discord.IGroupChannel>.RelationshipActor => Channel;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IGroupChannelActor, ulong, Discord.IGroupChannel>,
        Discord.IChannelActor.CanonicalRelationship
    {
        internal new Discord.IGroupChannelActor Channel { get; }
    
        Discord.IChannelActor Discord.IChannelActor.Relationship.Channel => Channel;
        Discord.IGroupChannelActor Discord.IGroupChannelActor.Relationship.Channel => Channel;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
