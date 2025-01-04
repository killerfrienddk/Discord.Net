using System.Text.Json.Serialization;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models.Json;

public partial class PartialVoiceState : 
    Discord.Models.IPartialVoiceStateModel
{
    [JsonPropertyName("guild_id")]
    public Discord.Optional<ulong> GuildId { get; set; }

    [JsonPropertyName("channel_id")]
    public Discord.Optional<ulong?> ChannelId { get; set; }

    [JsonPropertyName("member")]
    public Discord.Optional<Discord.Models.Json.GuildMember> Member { get; set; }

    [JsonPropertyName("session_id")]
    public Discord.Optional<string> SessionId { get; set; }

    [JsonPropertyName("deaf")]
    public Discord.Optional<bool> Deaf { get; set; }

    [JsonPropertyName("mute")]
    public Discord.Optional<bool> Mute { get; set; }

    [JsonPropertyName("self_deaf")]
    public Discord.Optional<bool> SelfDeaf { get; set; }

    [JsonPropertyName("self_mute")]
    public Discord.Optional<bool> SelfMute { get; set; }

    [JsonPropertyName("self_stream")]
    public Discord.Optional<bool?> SelfStream { get; set; }

    [JsonPropertyName("self_video")]
    public Discord.Optional<bool> SelfVideo { get; set; }

    [JsonPropertyName("suppress")]
    public Discord.Optional<bool> Suppress { get; set; }

    [JsonPropertyName("request_to_speak_timestamp")]
    public Discord.Optional<System.DateTimeOffset?> RequestToSpeakTimestamp { get; set; }
}
