using System.Text.Json.Serialization;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IPartialUserModel : 
    IPartialModel,
    IEntityModel<ulong>
{
    Discord.Optional<string> Username { get; }

    Discord.Optional<string> Discriminator { get; }

    Discord.Optional<string?> GlobalName { get; }

    Discord.Optional<string?> Avatar { get; }

    Discord.Optional<bool> IsBot { get; }

    Discord.Optional<bool> IsSystem { get; }

    Discord.Optional<int> Flags { get; }

    Discord.Optional<int> PublicFlags { get; }

    Discord.Optional<Discord.Models.IAvatarDecorationDataModel?> AvatarDecoration { get; }

    Type IPartialModel.UnderlyingModelType => typeof(Discord.Models.IUserModel);
}
