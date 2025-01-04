using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IEmbedVideoModel : 
    IEquatable<Discord.Models.IEmbedVideoModel>
{
    new bool Equals(Discord.Models.IEmbedVideoModel? other)
    {
        if(other is null) return false;
        
        return
            (this.Url.IsSpecified == other.Url.IsSpecified) && (!this.Url.IsSpecified || (EqualityComparer<string>.Default.Equals(this.Url.Value, other.Url.Value))) &&
            (this.ProxyUrl.IsSpecified == other.ProxyUrl.IsSpecified) && (!this.ProxyUrl.IsSpecified || (EqualityComparer<string>.Default.Equals(this.ProxyUrl.Value, other.ProxyUrl.Value))) &&
            (this.Height.IsSpecified == other.Height.IsSpecified) && (!this.Height.IsSpecified || (EqualityComparer<int>.Default.Equals(this.Height.Value, other.Height.Value))) &&
            (this.Width.IsSpecified == other.Width.IsSpecified) && (!this.Width.IsSpecified || (EqualityComparer<int>.Default.Equals(this.Width.Value, other.Width.Value)));
    }
    

    bool IEquatable<Discord.Models.IEmbedVideoModel>.Equals(Discord.Models.IEmbedVideoModel? other) => Equals(other);
}
