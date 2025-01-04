namespace Discord.Models;

[ModelEquality, HasPartialVariant]
public partial interface IUserModel : IEntityModel<ulong>
{
    string Username { get; }
    string Discriminator { get; }
    string? GlobalName { get; }
    string? Avatar { get; }
    Optional<bool> IsBot { get; }
    Optional<bool> IsSystem { get; }
    Optional<int> Flags { get; }
    Optional<int> PublicFlags { get; }
    Optional<IAvatarDecorationDataModel?> AvatarDecoration { get; }
}
