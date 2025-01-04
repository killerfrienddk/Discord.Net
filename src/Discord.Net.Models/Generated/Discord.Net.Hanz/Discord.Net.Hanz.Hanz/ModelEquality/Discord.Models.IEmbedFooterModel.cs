using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IEmbedFooterModel : 
    IEquatable<Discord.Models.IEmbedFooterModel>
{
    new bool Equals(Discord.Models.IEmbedFooterModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<string>.Default.Equals(this.Text, other.Text) &&
            (this.IconUrl.IsSpecified == other.IconUrl.IsSpecified) && (!this.IconUrl.IsSpecified || (EqualityComparer<string>.Default.Equals(this.IconUrl.Value, other.IconUrl.Value))) &&
            (this.ProxyIconUrl.IsSpecified == other.ProxyIconUrl.IsSpecified) && (!this.ProxyIconUrl.IsSpecified || (EqualityComparer<string>.Default.Equals(this.ProxyIconUrl.Value, other.ProxyIconUrl.Value)));
    }
    

    bool IEquatable<Discord.Models.IEmbedFooterModel>.Equals(Discord.Models.IEmbedFooterModel? other) => Equals(other);
}
