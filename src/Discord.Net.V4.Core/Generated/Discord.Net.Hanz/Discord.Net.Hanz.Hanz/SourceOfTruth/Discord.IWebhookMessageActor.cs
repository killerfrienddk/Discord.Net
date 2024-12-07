using Discord.Models;
using Discord.Rest;

namespace Discord;

public partial interface IWebhookMessageActor
{
    ulong IIdentifiable<ulong>.Id => Id;
}
