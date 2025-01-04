namespace Discord.Models;

[ModelEquality]
public partial interface IResolvedDataModel : IModel
{
    Optional<IReadOnlyDictionary<ulong, IUserModel>> Users { get; }
    Optional<IReadOnlyDictionary<ulong, IPartialMemberModel>> Members { get; }
    Optional<IReadOnlyDictionary<ulong, IRoleModel>> Roles { get; }
    Optional<IReadOnlyDictionary<ulong, IPartialChannelModel>> Channels { get; }
    Optional<IReadOnlyDictionary<ulong, IPartialMessageModel>> Messages { get; }
    Optional<IReadOnlyDictionary<ulong, IAttachmentModel>> Attachments { get; }
}
