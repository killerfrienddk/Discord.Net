namespace Discord.Models;

[ModelEquality]
public partial interface IStickerPackModel : IEntityModel<ulong>
{
    string Name { get; }
    ulong SkuId { get; }
    Optional<ulong> CoverStickerId { get; }
    string Description { get; }
    Optional<ulong> BannerAssetId { get; }
    
    IReadOnlyCollection<ModelOrId<IStickerModel, ulong>> Stickers { get; }
}
