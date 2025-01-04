using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IActivityPartyModel : 
    IEquatable<Discord.Models.IActivityPartyModel>
{
    new bool Equals(Discord.Models.IActivityPartyModel? other)
    {
        if(other is null) return false;
        
        return
            (this.Id.IsSpecified == other.Id.IsSpecified) && (!this.Id.IsSpecified || (EqualityComparer<string>.Default.Equals(this.Id.Value, other.Id.Value))) &&
            (this.Size.IsSpecified == other.Size.IsSpecified) && (!this.Size.IsSpecified || ((this.Size.Value is null == other.Size.Value is null) && (this.Size.Value is null || this.Size.Value.SequenceEqual(other.Size.Value!))));
    }
    

    bool IEquatable<Discord.Models.IActivityPartyModel>.Equals(Discord.Models.IActivityPartyModel? other) => Equals(other);
}
