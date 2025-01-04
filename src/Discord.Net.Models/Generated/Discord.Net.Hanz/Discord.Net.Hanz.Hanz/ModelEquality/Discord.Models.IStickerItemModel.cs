using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IStickerItemModel : 
    IEquatable<Discord.Models.IStickerItemModel>
{
    new bool Equals(Discord.Models.IStickerItemModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<string>.Default.Equals(this.Name, other.Name) &&
            EqualityComparer<int>.Default.Equals(this.FormatType, other.FormatType);
    }
    

    bool IEquatable<Discord.Models.IStickerItemModel>.Equals(Discord.Models.IStickerItemModel? other) => Equals(other);
}
