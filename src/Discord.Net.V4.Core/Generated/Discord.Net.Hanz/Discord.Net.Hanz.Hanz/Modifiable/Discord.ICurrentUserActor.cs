using Discord;
using Discord.Models;
using Discord.Rest;

namespace Discord;

public partial interface ICurrentUserActor : 
    Discord.IModifiable<ulong, Discord.ModifySelfUserProperties, Discord.Models.Json.ModifyCurrentUserParams, Discord.Models.ISelfUserModel>.Actor<Discord.ICurrentUserActor, Discord.ICurrentUser>,
    Discord.IModifiable<ulong, Discord.ModifySelfUserProperties, Discord.Models.Json.ModifyCurrentUserParams, Discord.Models.ISelfUserModel>
{
    internal new static IApiInOutRoute<Discord.Models.Json.ModifyCurrentUserParams, Discord.Models.ISelfUserModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyCurrentUserParams args
    ) => Discord.Rest.Routes.ModifyCurrentUser(body);

    static IApiInOutRoute<Discord.Models.Json.ModifyCurrentUserParams, Discord.Models.ISelfUserModel> Discord.IModifiable<ulong, Discord.ModifySelfUserProperties, Discord.Models.Json.ModifyCurrentUserParams, Discord.Models.ISelfUserModel>.Actor<Discord.ICurrentUserActor, Discord.ICurrentUser>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyCurrentUserParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyCurrentUserParams> Discord.IModifiable<ulong, Discord.ModifySelfUserProperties, Discord.Models.Json.ModifyCurrentUserParams, Discord.Models.ISelfUserModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyCurrentUserParams args
    ) => ModifyRoute(path, id, args);
}
public partial interface ICurrentUser : 
    Discord.IModifiable<ulong, Discord.ModifySelfUserProperties, Discord.Models.Json.ModifyCurrentUserParams, Discord.Models.ISelfUserModel>.Entity<Discord.ICurrentUser>,
    Discord.IModifiable<ulong, Discord.ModifySelfUserProperties, Discord.Models.Json.ModifyCurrentUserParams, Discord.Models.ISelfUserModel>
{
    internal new static IApiInOutRoute<Discord.Models.Json.ModifyCurrentUserParams, Discord.Models.ISelfUserModel> ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyCurrentUserParams args
    ) => Discord.Rest.Routes.ModifyCurrentUser(body);

    static IApiInOutRoute<Discord.Models.Json.ModifyCurrentUserParams, Discord.Models.ISelfUserModel> Discord.IModifiable<ulong, Discord.ModifySelfUserProperties, Discord.Models.Json.ModifyCurrentUserParams, Discord.Models.ISelfUserModel>.Entity<Discord.ICurrentUser>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyCurrentUserParams args
    ) => ModifyRoute(path, id, args);

    static IApiInRoute<Discord.Models.Json.ModifyCurrentUserParams> Discord.IModifiable<ulong, Discord.ModifySelfUserProperties, Discord.Models.Json.ModifyCurrentUserParams, Discord.Models.ISelfUserModel>.ModifyRoute(
        IPathable path,
        ulong id,
        Discord.Models.Json.ModifyCurrentUserParams args
    ) => ModifyRoute(path, id, args);
}
