using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IPrivateThreadChannelActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IPrivateThreadChannelActor, ulong, Discord.IPrivateThreadChannel>
    {
        Discord.IPrivateThreadChannelActor Thread { get; }
    
        Discord.IPrivateThreadChannelActor Discord.IRelationship<Discord.IPrivateThreadChannelActor, ulong, Discord.IPrivateThreadChannel>.RelationshipActor => Thread;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IPrivateThreadChannelActor, ulong, Discord.IPrivateThreadChannel>,
        Discord.IThreadChannelActor.CanonicalRelationship,
        Discord.IChannelActor.CanonicalRelationship
    {
        internal new Discord.IPrivateThreadChannelActor Thread { get; }
    
        Discord.IThreadChannelActor Discord.IThreadChannelActor.Relationship.Thread => Thread;
        Discord.IChannelActor Discord.IChannelActor.Relationship.Channel => Thread;
        Discord.IPrivateThreadChannelActor Discord.IPrivateThreadChannelActor.Relationship.Thread => Thread;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
