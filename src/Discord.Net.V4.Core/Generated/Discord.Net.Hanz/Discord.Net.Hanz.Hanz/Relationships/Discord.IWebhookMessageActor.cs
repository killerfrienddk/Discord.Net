using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IWebhookMessageActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IWebhookMessageActor, ulong, Discord.IWebhookMessage>
    {
        Discord.IWebhookMessageActor WebhookMessage { get; }
    
        Discord.IWebhookMessageActor Discord.IRelationship<Discord.IWebhookMessageActor, ulong, Discord.IWebhookMessage>.RelationshipActor => WebhookMessage;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IWebhookMessageActor, ulong, Discord.IWebhookMessage>,
        Discord.IMessageActor.CanonicalRelationship
    {
        new Discord.IWebhookActor Webhook => WebhookMessage.Webhook;
    
        Discord.IMessageActor Discord.IMessageActor.Relationship.Message => WebhookMessage;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
