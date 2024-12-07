using Discord.Models;
using Discord.Models.Json;
using Discord.Rest;
using System.Diagnostics.CodeAnalysis;

namespace Discord;

public partial interface ICurrentUser
{
    Discord.Models.ISelfUserModel IEntityOf<ISelfUserModel>.GetModel() => GetModel();

    Discord.Models.IUserModel IEntityOf<IUserModel>.GetModel() => GetModel();
}
