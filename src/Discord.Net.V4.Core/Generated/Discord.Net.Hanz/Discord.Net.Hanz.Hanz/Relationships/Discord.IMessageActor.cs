using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IMessageActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IMessageActor, ulong, Discord.IMessage>
    {
        Discord.IMessageActor Message { get; }
    
        Discord.IMessageActor Discord.IRelationship<Discord.IMessageActor, ulong, Discord.IMessage>.RelationshipActor => Message;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IMessageActor, ulong, Discord.IMessage>;
}
#pragma warning restore CS0108
#pragma warning restore CS0109
