using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IInteractionCallbackResponseActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IInteractionCallbackResponseActor, ulong, Discord.IInteractionCallbackResponse>
    {
        Discord.IInteractionCallbackResponseActor InteractionCallbackResponse { get; }
    
        Discord.IInteractionCallbackResponseActor Discord.IRelationship<Discord.IInteractionCallbackResponseActor, ulong, Discord.IInteractionCallbackResponse>.RelationshipActor => InteractionCallbackResponse;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IInteractionCallbackResponseActor, ulong, Discord.IInteractionCallbackResponse>;
}
#pragma warning restore CS0108
#pragma warning restore CS0109
