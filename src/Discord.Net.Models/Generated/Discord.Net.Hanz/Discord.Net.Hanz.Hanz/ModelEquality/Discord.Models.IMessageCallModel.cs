using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IMessageCallModel : 
    IEquatable<Discord.Models.IMessageCallModel>
{
    new bool Equals(Discord.Models.IMessageCallModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<System.Collections.Generic.IReadOnlyCollection<ulong>>.Default.Equals(this.Participants, other.Participants) &&
            (this.EndedTimestamp.IsSpecified == other.EndedTimestamp.IsSpecified) && (!this.EndedTimestamp.IsSpecified || (EqualityComparer<System.DateTimeOffset?>.Default.Equals(this.EndedTimestamp.Value, other.EndedTimestamp.Value)));
    }
    

    bool IEquatable<Discord.Models.IMessageCallModel>.Equals(Discord.Models.IMessageCallModel? other) => Equals(other);
}
