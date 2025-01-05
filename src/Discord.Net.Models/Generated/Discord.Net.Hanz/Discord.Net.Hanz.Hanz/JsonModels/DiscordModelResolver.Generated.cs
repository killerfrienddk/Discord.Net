using Discord;
using Discord.Models;
using Discord.Models.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Discord.Models.Json;

[
    JsonSerializable(typeof(System.DateTimeOffset)),
    JsonSerializable(typeof(System.Collections.Generic.IReadOnlyCollection<int>)),
    JsonSerializable(typeof(Discord.Models.Json.ActivityTimestamps)),
    JsonSerializable(typeof(Discord.DiscordEmojiId?)),
    JsonSerializable(typeof(Discord.Models.Json.ActivityParty)),
    JsonSerializable(typeof(Discord.Models.Json.ActivityAssets)),
    JsonSerializable(typeof(Discord.Models.Json.ActivitySecrets)),
    JsonSerializable(typeof(System.Collections.Generic.IReadOnlyCollection<Discord.Models.Json.ActivityButton>))
]
public partial class DiscordModelResolver : JsonSerializerContext;