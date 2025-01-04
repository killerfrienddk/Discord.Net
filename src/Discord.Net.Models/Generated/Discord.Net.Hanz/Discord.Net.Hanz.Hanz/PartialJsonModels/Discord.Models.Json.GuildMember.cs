using System.Text.Json.Serialization;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models.Json;

public partial class PartialGuildMember : 
    Discord.Models.IPartialMemberModel
{
    [JsonPropertyName("user")]
    public Discord.Optional<Discord.Models.Json.User> User { get; set; }

    [JsonPropertyName("nick")]
    public Discord.Optional<string?> Nick { get; set; }

    [JsonPropertyName("avatar")]
    public Discord.Optional<string?> Avatar { get; set; }

    [JsonPropertyName("roles")]
    public Discord.Optional<ulong[]> RoleIds { get; set; }

    [JsonPropertyName("joined_at")]
    public Discord.Optional<System.DateTimeOffset> JoinedAt { get; set; }

    [JsonPropertyName("premium_since")]
    public Discord.Optional<System.DateTimeOffset?> PremiumSince { get; set; }

    [JsonPropertyName("deaf")]
    public Discord.Optional<bool> Deaf { get; set; }

    [JsonPropertyName("mute")]
    public Discord.Optional<bool> Mute { get; set; }

    [JsonPropertyName("flags")]
    public Discord.Optional<int> Flags { get; set; }

    [JsonPropertyName("pending")]
    public Discord.Optional<bool> Pending { get; set; }

    [JsonPropertyName("permissions")]
    public Discord.Optional<ulong> Permissions { get; set; }

    [JsonPropertyName("communication_disabled_until")]
    public Discord.Optional<System.DateTimeOffset?> CommunicationsDisabledUntil { get; set; }

    [JsonPropertyName("avatar_decoration_data")]
    public Discord.Optional<Discord.Models.Json.AvatarDecorationData?> AvatarDecoration { get; set; }
}
