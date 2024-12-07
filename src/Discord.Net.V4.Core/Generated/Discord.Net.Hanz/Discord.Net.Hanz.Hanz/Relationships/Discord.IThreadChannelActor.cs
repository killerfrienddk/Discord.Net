using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IThreadChannelActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IThreadChannelActor, ulong, Discord.IThreadChannel>
    {
        Discord.IThreadChannelActor Thread { get; }
    
        Discord.IThreadChannelActor Discord.IRelationship<Discord.IThreadChannelActor, ulong, Discord.IThreadChannel>.RelationshipActor => Thread;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IThreadChannelActor, ulong, Discord.IThreadChannel>,
        Discord.IChannelActor.CanonicalRelationship
    {
        Discord.IChannelActor Discord.IChannelActor.Relationship.Channel => Thread;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
