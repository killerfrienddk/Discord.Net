using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IAvatarDecorationDataModel : 
    IEquatable<Discord.Models.IAvatarDecorationDataModel>
{
    new bool Equals(Discord.Models.IAvatarDecorationDataModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<string>.Default.Equals(this.Asset, other.Asset) &&
            EqualityComparer<ulong>.Default.Equals(this.SkuId, other.SkuId);
    }
    

    bool IEquatable<Discord.Models.IAvatarDecorationDataModel>.Equals(Discord.Models.IAvatarDecorationDataModel? other) => Equals(other);
}
