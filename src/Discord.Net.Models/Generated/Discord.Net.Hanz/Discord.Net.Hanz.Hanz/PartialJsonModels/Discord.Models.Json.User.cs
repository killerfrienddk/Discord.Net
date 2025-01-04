using System.Text.Json.Serialization;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models.Json;

public partial class PartialUser : 
    Discord.Models.IPartialUserModel
{
    [JsonPropertyName("id")]
    public Discord.Optional<ulong> Id { get; set; }

    [JsonPropertyName("username")]
    public Discord.Optional<string> Username { get; set; }

    [JsonPropertyName("discriminator")]
    public Discord.Optional<string> Discriminator { get; set; }

    [JsonPropertyName("global_name")]
    public Discord.Optional<string?> GlobalName { get; set; }

    [JsonPropertyName("avatar")]
    public Discord.Optional<string?> Avatar { get; set; }

    [JsonPropertyName("bot")]
    public Discord.Optional<bool> IsBot { get; set; }

    [JsonPropertyName("system")]
    public Discord.Optional<bool> IsSystem { get; set; }

    [JsonPropertyName("banner")]
    public Discord.Optional<string?> Banner { get; set; }

    [JsonPropertyName("accent_color")]
    public Discord.Optional<int?> AccentColor { get; set; }

    [JsonPropertyName("flags")]
    public Discord.Optional<int> Flags { get; set; }

    [JsonPropertyName("public_flags")]
    public Discord.Optional<int> PublicFlags { get; set; }

    [JsonPropertyName("avatar_decoration_data")]
    public Discord.Optional<Discord.Models.Json.AvatarDecorationData?> AvatarDecoration { get; set; }
}
