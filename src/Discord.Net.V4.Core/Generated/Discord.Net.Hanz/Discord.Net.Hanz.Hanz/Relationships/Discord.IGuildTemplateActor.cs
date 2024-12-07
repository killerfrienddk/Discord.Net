using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IGuildTemplateActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IGuildTemplateActor, string, Discord.IGuildTemplate>
    {
        Discord.IGuildTemplateActor GuildTemplate { get; }
    
        Discord.IGuildTemplateActor Discord.IRelationship<Discord.IGuildTemplateActor, string, Discord.IGuildTemplate>.RelationshipActor => GuildTemplate;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IGuildTemplateActor, string, Discord.IGuildTemplate>;
}
#pragma warning restore CS0108
#pragma warning restore CS0109
