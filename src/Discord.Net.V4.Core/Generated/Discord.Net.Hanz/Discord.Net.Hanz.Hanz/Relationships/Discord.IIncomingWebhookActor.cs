using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IIncomingWebhookActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IIncomingWebhookActor, ulong, Discord.IIncomingWebhook>
    {
        Discord.IIncomingWebhookActor IncomingWebhook { get; }
    
        Discord.IIncomingWebhookActor Discord.IRelationship<Discord.IIncomingWebhookActor, ulong, Discord.IIncomingWebhook>.RelationshipActor => IncomingWebhook;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IIncomingWebhookActor, ulong, Discord.IIncomingWebhook>,
        Discord.IGuildChannelWebhookActor.CanonicalRelationship,
        Discord.IWebhookActor.CanonicalRelationship
    {
        Discord.IGuildChannelWebhookActor Discord.IGuildChannelWebhookActor.Relationship.GuildChannelWebhook => IncomingWebhook;
        Discord.IWebhookActor Discord.IWebhookActor.Relationship.Webhook => IncomingWebhook;
        ulong Discord.IRelation<ulong, Discord.IWebhook>.RelationshipId => GuildChannelWebhook.Id;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
