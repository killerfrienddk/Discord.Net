using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface ISkuModel : 
    IEquatable<Discord.Models.ISkuModel>
{
    new bool Equals(Discord.Models.ISkuModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<int>.Default.Equals(this.Type, other.Type) &&
            EqualityComparer<ulong>.Default.Equals(this.ApplicationId, other.ApplicationId) &&
            EqualityComparer<string>.Default.Equals(this.Name, other.Name) &&
            EqualityComparer<string>.Default.Equals(this.Slug, other.Slug) &&
            EqualityComparer<int>.Default.Equals(this.Flags, other.Flags);
    }
    

    bool IEquatable<Discord.Models.ISkuModel>.Equals(Discord.Models.ISkuModel? other) => Equals(other);
}
