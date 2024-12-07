using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IIncomingWebhookWithTokenActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IIncomingWebhookWithTokenActor, ulong, Discord.IIncomingWebhook>
    {
        Discord.IIncomingWebhookWithTokenActor IncomingWebhookWithToken { get; }
    
        Discord.IIncomingWebhookWithTokenActor Discord.IRelationship<Discord.IIncomingWebhookWithTokenActor, ulong, Discord.IIncomingWebhook>.RelationshipActor => IncomingWebhookWithToken;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IIncomingWebhookWithTokenActor, ulong, Discord.IIncomingWebhook>,
        Discord.IIncomingWebhookActor.CanonicalRelationship,
        Discord.IGuildChannelWebhookActor.CanonicalRelationship,
        Discord.IWebhookActor.CanonicalRelationship
    {
        Discord.IIncomingWebhookActor Discord.IIncomingWebhookActor.Relationship.IncomingWebhook => IncomingWebhookWithToken;
        Discord.IGuildChannelWebhookActor Discord.IGuildChannelWebhookActor.Relationship.GuildChannelWebhook => IncomingWebhookWithToken;
        Discord.IWebhookActor Discord.IWebhookActor.Relationship.Webhook => IncomingWebhookWithToken;
        ulong Discord.IRelation<ulong, Discord.IIncomingWebhook>.RelationshipId => IncomingWebhookWithToken.Id;
        ulong Discord.IRelation<ulong, Discord.IWebhook>.RelationshipId => GuildChannelWebhook.Id;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
