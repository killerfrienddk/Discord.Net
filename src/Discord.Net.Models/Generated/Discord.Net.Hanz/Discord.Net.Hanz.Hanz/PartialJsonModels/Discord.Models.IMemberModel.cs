using System.Text.Json.Serialization;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IPartialMemberModel : 
    IPartialModel,
    IEntityModel<ulong>
{
    Discord.Optional<Discord.Models.ModelOrId<Discord.Models.IUserModel, ulong>> User { get; }

    Discord.Optional<int> Flags { get; }

    Discord.Optional<string?> Nickname { get; }

    Discord.Optional<string?> Avatar { get; }

    Discord.Optional<System.Collections.Generic.IReadOnlyCollection<ulong>> Roles { get; }

    Discord.Optional<System.DateTimeOffset> JoinedAt { get; }

    Discord.Optional<System.DateTimeOffset?> PremiumSince { get; }

    Discord.Optional<bool> IsPending { get; }

    Discord.Optional<System.DateTimeOffset?> CommunicationsDisabledUntil { get; }

    Discord.Optional<Discord.Models.IAvatarDecorationDataModel?> AvatarDecoration { get; }

    Type IPartialModel.UnderlyingModelType => typeof(Discord.Models.IMemberModel);
}
