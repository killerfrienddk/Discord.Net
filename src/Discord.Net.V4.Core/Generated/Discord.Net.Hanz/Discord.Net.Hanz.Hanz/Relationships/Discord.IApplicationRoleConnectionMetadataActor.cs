using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IApplicationRoleConnectionMetadataActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IApplicationRoleConnectionMetadataActor, string, Discord.IApplicationRoleConnectionMetadata>
    {
        Discord.IApplicationRoleConnectionMetadataActor ApplicationRoleConnectionMetadata { get; }
    
        Discord.IApplicationRoleConnectionMetadataActor Discord.IRelationship<Discord.IApplicationRoleConnectionMetadataActor, string, Discord.IApplicationRoleConnectionMetadata>.RelationshipActor => ApplicationRoleConnectionMetadata;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IApplicationRoleConnectionMetadataActor, string, Discord.IApplicationRoleConnectionMetadata>
    {
        new Discord.IApplicationActor Application => ApplicationRoleConnectionMetadata.Application;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
