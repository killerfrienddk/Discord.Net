using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface ICurrentApplicationActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.ICurrentApplicationActor, ulong, Discord.ICurrentApplication>
    {
        Discord.ICurrentApplicationActor CurrentApplication { get; }
    
        Discord.ICurrentApplicationActor Discord.IRelationship<Discord.ICurrentApplicationActor, ulong, Discord.ICurrentApplication>.RelationshipActor => CurrentApplication;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.ICurrentApplicationActor, ulong, Discord.ICurrentApplication>,
        Discord.IApplicationActor.CanonicalRelationship
    {
        Discord.IApplicationActor Discord.IApplicationActor.Relationship.Application => CurrentApplication;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
