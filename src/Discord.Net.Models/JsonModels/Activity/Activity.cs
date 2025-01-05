using Discord.Converters;
using System.Text.Json.Serialization;

namespace Discord.Models.Json;

[JsonModel]
public sealed partial record Activity(
    [property: JsonPropertyName("name")]           string Name,
    [property: JsonPropertyName("type")]           int Type,
    [property: JsonPropertyName("url")]            Optional<string?> Url,
    [property: JsonPropertyName("created_at")]     DateTimeOffset CreatedAt,
    [property: JsonPropertyName("timestamps")]     Optional<ActivityTimestamps> Timestamps,
    [property: JsonPropertyName("application_id")] Optional<ulong> ApplicationId,
    [property: JsonPropertyName("details")]        Optional<string?> Details,
    [property: JsonPropertyName("state")]          Optional<string?> State,
    [property: JsonPropertyName("emoji")]          Optional<DiscordEmojiId?> Emoji,
    [property: JsonPropertyName("party")]          Optional<ActivityParty> Party,
    [property: JsonPropertyName("assets")]         Optional<ActivityAssets> Assets,
    [property: JsonPropertyName("secrets")]        Optional<ActivitySecrets> Secrets,
    [property: JsonPropertyName("instance")]       Optional<bool> IsInstance,
    [property: JsonPropertyName("flags")]          Optional<int> Flags,
    [property: JsonPropertyName("buttons")]        Optional<IReadOnlyCollection<ActivityButton>> Buttons
) : IActivityModel
{
    Optional<IActivityTimestampsModel> IActivityModel.Timestamps => Timestamps.As(default(IActivityTimestampsModel));

    Optional<DiscordEmojiId?> IActivityModel.Emoji => Emoji.As(default(DiscordEmojiId?));

    Optional<IActivityPartyModel> IActivityModel.Party => Party.As(default(IActivityPartyModel));

    Optional<IActivityAssetsModel> IActivityModel.Assets => Assets.As(default(IActivityAssetsModel));

    Optional<IActivitySecretsModel> IActivityModel.Secrets => Secrets.As(default(IActivitySecretsModel));

    Optional<IReadOnlyCollection<IActivityButtonModel>> IActivityModel.Buttons 
        => Buttons.As(default(IReadOnlyCollection<IActivityButtonModel>));
}

// public sealed class Activity :
//     IActivityModel
// {
//     [JsonPropertyName("name")]
//     public required string Name { get; set; }
//
//     [JsonPropertyName("type")]
//     public int Type { get; set; }
//
//     [JsonPropertyName("url")]
//     public Optional<string?> Url { get; set; }
//
//     [JsonPropertyName("created_at")]
//     [JsonConverter(typeof(MillisecondEpocConverter))]
//     public DateTimeOffset CreatedAt { get; set; }
//
//     [JsonPropertyName("timestamps")]
//     public Optional<ActivityTimestamps> Timestamps { get; set; }
//
//     IOptional<IActivityTimestampsModel> IActivityModel.Timestamps => Timestamps;
//
//     [JsonPropertyName("application_id")]
//     public Optional<ulong> ApplicationId { get; set; }
//
//     [JsonPropertyName("details")]
//     public Optional<string?> Details { get; set; }
//
//     [JsonPropertyName("state")]
//     public Optional<string?> State { get; set; }
//
//     [JsonPropertyName("emoji")]
//     public Optional<IEmojiModel?> Emoji { get; set; }
//
//     [JsonPropertyName("party")]
//     public Optional<ActivityParty> Party { get; set; }
//
//     [JsonPropertyName("assets")]
//     public Optional<ActivityAssets> Assets { get; set; }
//
//     [JsonPropertyName("secrets")]
//     public Optional<ActivitySecrets> Secrets { get; set; }
//
//     [JsonPropertyName("instance")]
//     public Optional<bool> Instance { get; set; }
//
//     [JsonPropertyName("flags")]
//     public Optional<int> Flags { get; set; }
//
//     [JsonPropertyName("buttons")]
//     public Optional<ActivityButton[]> Buttons { get; set; }
// }