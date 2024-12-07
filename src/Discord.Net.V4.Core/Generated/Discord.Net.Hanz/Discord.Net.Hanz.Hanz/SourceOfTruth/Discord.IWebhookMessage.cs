using Discord.Rest;

namespace Discord;

public partial interface IWebhookMessage
{
    Discord.IWebhookActor? IMessage.Webhook => Webhook;
}
