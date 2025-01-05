using System.Text.Json.Serialization.Metadata;
using System.Text.Json.Serialization;
using System.Text.Json;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models.Json;

public partial class DiscordModelResolver
{
    public JsonTypeInfo<Discord.Models.Json.ActivityTimestamps> ActivityTimestamps => GetOrInitTypeInfo(ref _ActivityTimestamps);

    public JsonTypeInfo<Discord.Models.Json.ActivitySecrets> ActivitySecrets => GetOrInitTypeInfo(ref _ActivitySecrets);

    public JsonTypeInfo<Discord.Models.Json.ActivityParty> ActivityParty => GetOrInitTypeInfo(ref _ActivityParty);

    public JsonTypeInfo<Discord.Models.Json.ActivityButton> ActivityButton => GetOrInitTypeInfo(ref _ActivityButton);

    public JsonTypeInfo<Discord.Models.Json.ActivityAssets> ActivityAssets => GetOrInitTypeInfo(ref _ActivityAssets);

    public JsonTypeInfo<Discord.Models.Json.Activity> Activity => GetOrInitTypeInfo(ref _Activity);

    private JsonTypeInfo<Discord.Models.Json.ActivityTimestamps>? _ActivityTimestamps;
    private JsonTypeInfo<Discord.Models.Json.ActivitySecrets>? _ActivitySecrets;
    private JsonTypeInfo<Discord.Models.Json.ActivityParty>? _ActivityParty;
    private JsonTypeInfo<Discord.Models.Json.ActivityButton>? _ActivityButton;
    private JsonTypeInfo<Discord.Models.Json.ActivityAssets>? _ActivityAssets;
    private JsonTypeInfo<Discord.Models.Json.Activity>? _Activity;
}
