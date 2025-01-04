using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IMessageActivityModel : 
    IEquatable<Discord.Models.IMessageActivityModel>
{
    new bool Equals(Discord.Models.IMessageActivityModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<int>.Default.Equals(this.Type, other.Type) &&
            (this.PartyId.IsSpecified == other.PartyId.IsSpecified) && (!this.PartyId.IsSpecified || (EqualityComparer<string>.Default.Equals(this.PartyId.Value, other.PartyId.Value)));
    }
    

    bool IEquatable<Discord.Models.IMessageActivityModel>.Equals(Discord.Models.IMessageActivityModel? other) => Equals(other);
}
