using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IGuildChannelWebhookActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook>
    {
        Discord.IGuildChannelWebhookActor GuildChannelWebhook { get; }
    
        Discord.IGuildChannelWebhookActor Discord.IRelationship<Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook>.RelationshipActor => GuildChannelWebhook;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IGuildChannelWebhookActor, ulong, Discord.IWebhook>,
        Discord.IWebhookActor.CanonicalRelationship
    {
        Discord.IWebhookActor Discord.IWebhookActor.Relationship.Webhook => GuildChannelWebhook;
        ulong Discord.IRelation<ulong, Discord.IWebhook>.RelationshipId => GuildChannelWebhook.Id;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
