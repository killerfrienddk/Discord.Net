using System.Text.Json.Serialization;

namespace Discord.Models.Json;

[JsonModel]
public sealed partial class ActivityParty : IActivityPartyModel
{
    [JsonPropertyName("id")]
    public Optional<string> Id { get; set; }

    [JsonPropertyName("size")]
    public Optional<IReadOnlyCollection<int>> Size { get; set; }
}
