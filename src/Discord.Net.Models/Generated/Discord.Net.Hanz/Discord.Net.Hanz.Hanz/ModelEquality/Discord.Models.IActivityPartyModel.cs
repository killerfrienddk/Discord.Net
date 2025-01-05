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
            (this.Size.IsSpecified == other.Size.IsSpecified) && (!this.Size.IsSpecified || (EqualityComparer<System.Collections.Generic.IReadOnlyCollection<int>>.Default.Equals(this.Size.Value, other.Size.Value)));
    }
    

    bool IEquatable<Discord.Models.IActivityPartyModel>.Equals(Discord.Models.IActivityPartyModel? other) => Equals(other);
}
