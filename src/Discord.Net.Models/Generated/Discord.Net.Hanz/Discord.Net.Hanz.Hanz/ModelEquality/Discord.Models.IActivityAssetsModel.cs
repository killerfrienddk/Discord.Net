using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IActivityAssetsModel : 
    IEquatable<Discord.Models.IActivityAssetsModel>
{
    new bool Equals(Discord.Models.IActivityAssetsModel? other)
    {
        if(other is null) return false;
        
        return
            (this.LargeImage.IsSpecified == other.LargeImage.IsSpecified) && (!this.LargeImage.IsSpecified || (EqualityComparer<string>.Default.Equals(this.LargeImage.Value, other.LargeImage.Value))) &&
            (this.LargeText.IsSpecified == other.LargeText.IsSpecified) && (!this.LargeText.IsSpecified || (EqualityComparer<string>.Default.Equals(this.LargeText.Value, other.LargeText.Value))) &&
            (this.SmallImage.IsSpecified == other.SmallImage.IsSpecified) && (!this.SmallImage.IsSpecified || (EqualityComparer<string>.Default.Equals(this.SmallImage.Value, other.SmallImage.Value))) &&
            (this.SmallText.IsSpecified == other.SmallText.IsSpecified) && (!this.SmallText.IsSpecified || (EqualityComparer<string>.Default.Equals(this.SmallText.Value, other.SmallText.Value)));
    }
    

    bool IEquatable<Discord.Models.IActivityAssetsModel>.Equals(Discord.Models.IActivityAssetsModel? other) => Equals(other);
}
