using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IInteractionWithIdAndTokenActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IInteractionWithIdAndTokenActor, ulong, Discord.IInteraction>
    {
        Discord.IInteractionWithIdAndTokenActor InteractionWithIdAndToken { get; }
    
        Discord.IInteractionWithIdAndTokenActor Discord.IRelationship<Discord.IInteractionWithIdAndTokenActor, ulong, Discord.IInteraction>.RelationshipActor => InteractionWithIdAndToken;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IInteractionWithIdAndTokenActor, ulong, Discord.IInteraction>,
        Discord.IInteractionActor.CanonicalRelationship
    {
        Discord.IInteractionActor Discord.IInteractionActor.Relationship.Interaction => InteractionWithIdAndToken;
        ulong Discord.IRelation<ulong, Discord.IInteraction>.RelationshipId => InteractionWithIdAndToken.Id;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
