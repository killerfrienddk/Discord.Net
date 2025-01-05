using Discord.Converters;
using System.Text.Json.Serialization;

namespace Discord.Models.Json;

[JsonModel]
public sealed partial class ActivityTimestamps : IActivityTimestampsModel
{
    [JsonPropertyName("start")]
    //[JsonConverter(typeof(MillisecondEpocConverter))]
    public Optional<DateTimeOffset> Start { get; set; }

    [JsonPropertyName("end")]
    //[JsonConverter(typeof(MillisecondEpocConverter))]
    public Optional<DateTimeOffset> End { get; set; }
}
