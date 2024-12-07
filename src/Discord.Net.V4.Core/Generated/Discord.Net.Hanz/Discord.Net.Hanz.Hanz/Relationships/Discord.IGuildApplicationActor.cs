using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IGuildApplicationActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IGuildApplicationActor, ulong, Discord.IApplication>
    {
        Discord.IGuildApplicationActor GuildApplication { get; }
    
        Discord.IGuildApplicationActor Discord.IRelationship<Discord.IGuildApplicationActor, ulong, Discord.IApplication>.RelationshipActor => GuildApplication;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IGuildApplicationActor, ulong, Discord.IApplication>,
        Discord.IApplicationActor.CanonicalRelationship
    {
        new Discord.IGuildActor Guild => GuildApplication.Guild;
    
        Discord.IApplicationActor Discord.IApplicationActor.Relationship.Application => GuildApplication;
        ulong Discord.IRelation<ulong, Discord.IApplication>.RelationshipId => GuildApplication.Id;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
