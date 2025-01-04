namespace Discord.Models;

[ModelEquality]
public partial interface IPresenceModel : IEntityModel<ulong>
{
    ModelOrId<IPartialUserModel, ulong> User { get; }
    ulong GuildId { get; }
    string Status { get; }
    IReadOnlyCollection<IActivityModel> Activities { get; }
    IClientStatusModel ClientStatus { get; }

    ulong IEntityModel<ulong>.Id => User.Id;
}
