using System.Text.Json.Serialization;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models.Json;

public partial class PartialEmote : 
    Discord.Models.IPartialEmoteModel
{
    [JsonPropertyName("name")]
    public Discord.Optional<string> Name { get; set; }
}
