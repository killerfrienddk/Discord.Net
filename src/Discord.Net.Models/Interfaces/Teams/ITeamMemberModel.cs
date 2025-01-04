namespace Discord.Models;

[ModelEquality]
public partial interface ITeamMemberModel :
    IEntityModel<ulong>
{
    int MembershipState { get; }
    ulong TeamId { get; }
    string Role { get; }
    ModelOrId<IPartialUserModel, ulong> User { get; }

    ulong IEntityModel<ulong>.Id => User.Id;
}