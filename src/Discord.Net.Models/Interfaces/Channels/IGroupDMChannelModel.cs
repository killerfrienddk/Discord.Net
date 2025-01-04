namespace Discord.Models;

[ModelEquality, HasPartialVariant]
public partial interface IGroupDMChannelModel : IChannelModel
{
    IReadOnlyCollection<ModelOrId<IUserModel, ulong>> Recipients { get; }
    ulong OwnerId { get; }
}
