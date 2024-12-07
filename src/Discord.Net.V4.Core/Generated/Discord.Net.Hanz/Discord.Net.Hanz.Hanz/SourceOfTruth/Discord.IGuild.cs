using Discord.Models;
using Discord.Models.Json;
using Discord.Rest;
using System.Globalization;

namespace Discord;

public partial interface IGuild
{
    Discord.Models.IGuildModel IEntityOf<IGuildModel>.GetModel() => GetModel();

    Discord.Models.IPartialGuildModel IEntityOf<IPartialGuildModel>.GetModel() => GetModel();
}
