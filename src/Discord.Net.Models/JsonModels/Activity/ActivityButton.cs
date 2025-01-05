using System.Text.Json.Serialization;

namespace Discord.Models.Json;

[JsonModel]
public sealed partial class ActivityButton : IActivityButtonModel
{
    [JsonPropertyName("label")]
    public required string Label { get; set; }

    [JsonPropertyName("url")]
    public required string Url { get; set; }
}
