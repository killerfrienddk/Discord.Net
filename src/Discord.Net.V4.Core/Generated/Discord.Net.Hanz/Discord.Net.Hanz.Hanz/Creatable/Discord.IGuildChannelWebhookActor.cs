using Discord;
using Discord.Models;

namespace Discord;

public partial interface IGuildChannelWebhookActor : 
    Discord.ICreatable<Discord.IGuildChannelWebhookActor, Discord.IWebhook, ulong, Discord.CreateWebhookProperties, Discord.Models.Json.CreateWebhookParams, Discord.Models.IWebhookModel>
{
    internal static new IApiInOutRoute<Discord.Models.Json.CreateWebhookParams, Discord.Models.IWebhookModel> CreateRoute(IPathable path, Discord.Models.Json.CreateWebhookParams args) => Discord.Rest.Routes.CreateChannelWebhook(path.Require<Discord.IIntegrationChannel>(), args);

    static IApiInOutRoute<Discord.Models.Json.CreateWebhookParams, Discord.Models.IWebhookModel> Discord.ICreatable<Discord.IGuildChannelWebhookActor, Discord.IWebhook, ulong, Discord.CreateWebhookProperties, Discord.Models.Json.CreateWebhookParams, Discord.Models.IWebhookModel>.CreateRoute(IPathable path, Discord.Models.Json.CreateWebhookParams args) => CreateRoute(path, args);
}
