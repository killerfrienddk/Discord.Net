namespace Discord.Models;

[ModelEquality, HasPartialVariant]
public partial interface IMemberModel : IEntityModel<ulong>
{
    ModelOrId<IUserModel, ulong> User { get; }
    int Flags { get; }
    Optional<string?> Nickname { get;}
    Optional<string?> Avatar { get;}
    IReadOnlyCollection<ulong> Roles { get;}
    DateTimeOffset JoinedAt { get;}
    Optional<DateTimeOffset?> PremiumSince { get;}
    Optional<bool> IsPending { get;}
    Optional<DateTimeOffset?> CommunicationsDisabledUntil { get; }
    Optional<IAvatarDecorationDataModel?> AvatarDecoration { get; }

    ulong IEntityModel<ulong>.Id => User.Id;
}
