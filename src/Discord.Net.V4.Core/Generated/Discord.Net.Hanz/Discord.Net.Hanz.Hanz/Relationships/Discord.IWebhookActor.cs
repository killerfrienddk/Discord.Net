using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IWebhookActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IWebhookActor, ulong, Discord.IWebhook>
    {
        Discord.IWebhookActor Webhook { get; }
    
        Discord.IWebhookActor Discord.IRelationship<Discord.IWebhookActor, ulong, Discord.IWebhook>.RelationshipActor => Webhook;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IWebhookActor, ulong, Discord.IWebhook>;
}
#pragma warning restore CS0108
#pragma warning restore CS0109
