using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IChannelFollowerWebhookActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IChannelFollowerWebhookActor, ulong, Discord.IChannelFollowerWebhook>
    {
        Discord.IChannelFollowerWebhookActor ChannelFollowerWebhook { get; }
    
        Discord.IChannelFollowerWebhookActor Discord.IRelationship<Discord.IChannelFollowerWebhookActor, ulong, Discord.IChannelFollowerWebhook>.RelationshipActor => ChannelFollowerWebhook;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IChannelFollowerWebhookActor, ulong, Discord.IChannelFollowerWebhook>,
        Discord.IGuildChannelWebhookActor.CanonicalRelationship,
        Discord.IWebhookActor.CanonicalRelationship
    {
        Discord.IGuildChannelWebhookActor Discord.IGuildChannelWebhookActor.Relationship.GuildChannelWebhook => ChannelFollowerWebhook;
        Discord.IWebhookActor Discord.IWebhookActor.Relationship.Webhook => ChannelFollowerWebhook;
        ulong Discord.IRelation<ulong, Discord.IWebhook>.RelationshipId => GuildChannelWebhook.Id;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
