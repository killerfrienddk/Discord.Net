namespace Discord.Models;

[ModelEquality, HasPartialVariant]
public partial interface IChannelModel : IEntityModel<ulong>
{
    int Type { get; }
}
