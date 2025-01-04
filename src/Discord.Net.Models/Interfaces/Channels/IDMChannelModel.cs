namespace Discord.Models;

[ModelEquality, HasPartialVariant]
public partial interface IDMChannelModel : IChannelModel
{
    ModelOrId<IUserModel, ulong> Recipient { get; }
}
