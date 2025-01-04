using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IEmbedAuthorModel : 
    IEquatable<Discord.Models.IEmbedAuthorModel>
{
    new bool Equals(Discord.Models.IEmbedAuthorModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<string>.Default.Equals(this.Name, other.Name) &&
            (this.Url.IsSpecified == other.Url.IsSpecified) && (!this.Url.IsSpecified || (EqualityComparer<string>.Default.Equals(this.Url.Value, other.Url.Value))) &&
            (this.IconUrl.IsSpecified == other.IconUrl.IsSpecified) && (!this.IconUrl.IsSpecified || (EqualityComparer<string>.Default.Equals(this.IconUrl.Value, other.IconUrl.Value))) &&
            (this.ProxyIconUrl.IsSpecified == other.ProxyIconUrl.IsSpecified) && (!this.ProxyIconUrl.IsSpecified || (EqualityComparer<string>.Default.Equals(this.ProxyIconUrl.Value, other.ProxyIconUrl.Value)));
    }
    

    bool IEquatable<Discord.Models.IEmbedAuthorModel>.Equals(Discord.Models.IEmbedAuthorModel? other) => Equals(other);
}
