using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IInteractionActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IInteractionActor, ulong, Discord.IInteraction>
    {
        Discord.IInteractionActor Interaction { get; }
    
        Discord.IInteractionActor Discord.IRelationship<Discord.IInteractionActor, ulong, Discord.IInteraction>.RelationshipActor => Interaction;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IInteractionActor, ulong, Discord.IInteraction>;
}
#pragma warning restore CS0108
#pragma warning restore CS0109
