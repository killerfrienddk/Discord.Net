

namespace Discord.Models;

public partial interface IPartialUserModel : Discord.Models.IPartial<Discord.Models.IUserModel>, Discord.Models.IEntityModel<ulong>
{
    string? Username { get; }

    bool UsernameIsSpecified { get; }

    string? Discriminator { get; }

    bool DiscriminatorIsSpecified { get; }

    string? GlobalName { get; }

    bool GlobalNameIsSpecified { get; }

    string? Avatar { get; }

    bool AvatarIsSpecified { get; }

    bool? IsBot { get; }

    bool IsBotIsSpecified { get; }

    bool? IsSystem { get; }

    bool IsSystemIsSpecified { get; }

    int? Flags { get; }

    bool FlagsIsSpecified { get; }

    int? PublicFlags { get; }

    bool PublicFlagsIsSpecified { get; }

    Discord.Models.IAvatarDecorationDataModel? AvatarDecoration { get; }

    bool AvatarDecorationIsSpecified { get; }
}