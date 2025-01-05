using System.Text.Json.Serialization;

namespace Discord.Models.Json;

[JsonModel]
public sealed partial class ActivitySecrets : IActivitySecretsModel
{
    [JsonPropertyName("match")]
    public Optional<string> Match { get; set; }

    [JsonPropertyName("join")]
    public Optional<string> Join { get; set; }

    [JsonPropertyName("spectate")]
    public Optional<string> Spectate { get; set; }
}
