using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IStickerModel : 
    IEquatable<Discord.Models.IStickerModel>
{
    new bool Equals(Discord.Models.IStickerModel? other)
    {
        if(other is null) return false;
        
        return
            (this.PackId.IsSpecified == other.PackId.IsSpecified) && (!this.PackId.IsSpecified || (EqualityComparer<ulong>.Default.Equals(this.PackId.Value, other.PackId.Value))) &&
            EqualityComparer<string>.Default.Equals(this.Name, other.Name) &&
            EqualityComparer<string?>.Default.Equals(this.Description, other.Description) &&
            EqualityComparer<string>.Default.Equals(this.Tags, other.Tags) &&
            EqualityComparer<int>.Default.Equals(this.Type, other.Type) &&
            EqualityComparer<int>.Default.Equals(this.FormatType, other.FormatType) &&
            (this.SortValue.IsSpecified == other.SortValue.IsSpecified) && (!this.SortValue.IsSpecified || (EqualityComparer<int>.Default.Equals(this.SortValue.Value, other.SortValue.Value)));
    }
    

    bool IEquatable<Discord.Models.IStickerModel>.Equals(Discord.Models.IStickerModel? other) => Equals(other);
}
