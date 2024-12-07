using Discord.Models;
using Discord.Rest;

namespace Discord;

public partial interface IChannelFollowerWebhook
{
    Discord.Models.IWebhookModel IEntityOf<IWebhookModel>.GetModel() => GetModel();

    Discord.Models.IChannelFollowerWebhookModel IEntityOf<IChannelFollowerWebhookModel>.GetModel() => GetModel();
}
