using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IIntegrationActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IIntegrationActor, ulong, Discord.IIntegration>
    {
        Discord.IIntegrationActor Integration { get; }
    
        Discord.IIntegrationActor Discord.IRelationship<Discord.IIntegrationActor, ulong, Discord.IIntegration>.RelationshipActor => Integration;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IIntegrationActor, ulong, Discord.IIntegration>
    {
        new Discord.IGuildActor Guild => Integration.Guild;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
