using System.Text.Json.Serialization.Metadata;
using System.Text.Json.Serialization;
using System.Text.Json;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models.Json;

public partial class DiscordModelResolver
{
    internal static readonly IReadOnlyDictionary<Type, Type> InterfaceModelMap = new Dictionary<Type, Type>()
    {
        { typeof(Discord.Models.IActivityTimestampsModel), typeof(Discord.Models.Json.ActivityTimestamps) },
        { typeof(Discord.Models.IActivitySecretsModel), typeof(Discord.Models.Json.ActivitySecrets) },
        { typeof(Discord.Models.IActivityPartyModel), typeof(Discord.Models.Json.ActivityParty) },
        { typeof(Discord.Models.IActivityButtonModel), typeof(Discord.Models.Json.ActivityButton) },
        { typeof(Discord.Models.IActivityAssetsModel), typeof(Discord.Models.Json.ActivityAssets) },
        { typeof(Discord.Models.IActivityModel), typeof(Discord.Models.Json.Activity) }
    };
}
