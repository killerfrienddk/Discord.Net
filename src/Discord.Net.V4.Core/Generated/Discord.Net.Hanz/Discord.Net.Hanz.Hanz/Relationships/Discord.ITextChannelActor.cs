using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface ITextChannelActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.ITextChannelActor, ulong, Discord.ITextChannel>
    {
        Discord.ITextChannelActor Channel { get; }
    
        Discord.ITextChannelActor Discord.IRelationship<Discord.ITextChannelActor, ulong, Discord.ITextChannel>.RelationshipActor => Channel;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.ITextChannelActor, ulong, Discord.ITextChannel>,
        Discord.IGuildChannelActor.CanonicalRelationship,
        Discord.IChannelActor.CanonicalRelationship
    {
        internal new Discord.ITextChannelActor Channel { get; }
    
        Discord.IGuildChannelActor Discord.IGuildChannelActor.Relationship.Channel => Channel;
        Discord.IChannelActor Discord.IChannelActor.Relationship.Channel => Channel;
        Discord.ITextChannelActor Discord.ITextChannelActor.Relationship.Channel => Channel;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
