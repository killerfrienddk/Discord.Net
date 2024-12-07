using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IGuildTemplateFromGuildActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IGuildTemplateFromGuildActor, string, Discord.IGuildTemplate>
    {
        Discord.IGuildTemplateFromGuildActor GuildTemplateFromGuild { get; }
    
        Discord.IGuildTemplateFromGuildActor Discord.IRelationship<Discord.IGuildTemplateFromGuildActor, string, Discord.IGuildTemplate>.RelationshipActor => GuildTemplateFromGuild;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IGuildTemplateFromGuildActor, string, Discord.IGuildTemplate>,
        Discord.IGuildTemplateActor.CanonicalRelationship
    {
        new Discord.IGuildActor Guild => GuildTemplateFromGuild.Guild;
    
        Discord.IGuildTemplateActor Discord.IGuildTemplateActor.Relationship.GuildTemplate => GuildTemplateFromGuild;
        string Discord.IRelation<string, Discord.IGuildTemplate>.RelationshipId => GuildTemplateFromGuild.Id;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
