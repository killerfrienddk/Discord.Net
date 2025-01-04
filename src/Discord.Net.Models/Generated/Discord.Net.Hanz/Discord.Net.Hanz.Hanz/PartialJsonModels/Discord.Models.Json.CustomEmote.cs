using System.Text.Json.Serialization;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models.Json;

public partial class PartialCustomEmote : 
    Discord.Models.Json.PartialEmote,
    Discord.Models.IPartialCustomEmoteModel
{
    [JsonPropertyName("roles")]
    public Discord.Optional<ulong[]> RoleIds { get; set; }

    [JsonPropertyName("user")]
    public Discord.Optional<Discord.Models.Json.User> User { get; set; }

    [JsonPropertyName("require_colons")]
    public Discord.Optional<bool> RequireColons { get; set; }

    [JsonPropertyName("managed")]
    public Discord.Optional<bool> Managed { get; set; }

    [JsonPropertyName("animated")]
    public Discord.Optional<bool> Animated { get; set; }

    [JsonPropertyName("available")]
    public Discord.Optional<bool> Available { get; set; }
}
