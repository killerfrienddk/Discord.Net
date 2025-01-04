using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IStickerPackModel : 
    IEquatable<Discord.Models.IStickerPackModel>
{
    new bool Equals(Discord.Models.IStickerPackModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<string>.Default.Equals(this.Name, other.Name) &&
            EqualityComparer<ulong>.Default.Equals(this.SkuId, other.SkuId) &&
            (this.CoverStickerId.IsSpecified == other.CoverStickerId.IsSpecified) && (!this.CoverStickerId.IsSpecified || (EqualityComparer<ulong>.Default.Equals(this.CoverStickerId.Value, other.CoverStickerId.Value))) &&
            EqualityComparer<string>.Default.Equals(this.Description, other.Description) &&
            (this.BannerAssetId.IsSpecified == other.BannerAssetId.IsSpecified) && (!this.BannerAssetId.IsSpecified || (EqualityComparer<ulong>.Default.Equals(this.BannerAssetId.Value, other.BannerAssetId.Value))) &&
            EqualityComparer<System.Collections.Generic.IReadOnlyCollection<Discord.Models.ModelOrId<Discord.Models.IStickerModel, ulong>>>.Default.Equals(this.Stickers, other.Stickers);
    }
    

    bool IEquatable<Discord.Models.IStickerPackModel>.Equals(Discord.Models.IStickerPackModel? other) => Equals(other);
}
