using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IInteractionMessageActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IInteractionMessageActor, ulong, Discord.IMessage>
    {
        Discord.IInteractionMessageActor InteractionMessage { get; }
    
        Discord.IInteractionMessageActor Discord.IRelationship<Discord.IInteractionMessageActor, ulong, Discord.IMessage>.RelationshipActor => InteractionMessage;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IInteractionMessageActor, ulong, Discord.IMessage>
    {
        new Discord.IApplicationActor Application => InteractionMessage.Application;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
