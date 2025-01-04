using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IEmbedProviderModel : 
    IEquatable<Discord.Models.IEmbedProviderModel>
{
    new bool Equals(Discord.Models.IEmbedProviderModel? other)
    {
        if(other is null) return false;
        
        return
            (this.Name.IsSpecified == other.Name.IsSpecified) && (!this.Name.IsSpecified || (EqualityComparer<string>.Default.Equals(this.Name.Value, other.Name.Value))) &&
            (this.Url.IsSpecified == other.Url.IsSpecified) && (!this.Url.IsSpecified || (EqualityComparer<string>.Default.Equals(this.Url.Value, other.Url.Value)));
    }
    

    bool IEquatable<Discord.Models.IEmbedProviderModel>.Equals(Discord.Models.IEmbedProviderModel? other) => Equals(other);
}
