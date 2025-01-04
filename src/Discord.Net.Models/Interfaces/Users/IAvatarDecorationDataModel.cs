namespace Discord.Models;

[ModelEquality]
public partial interface IAvatarDecorationDataModel : IModel
{
    string Asset { get; }
    ulong SkuId { get; }
}
