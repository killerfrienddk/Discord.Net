using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IActivityTimestampsModel : 
    IEquatable<Discord.Models.IActivityTimestampsModel>
{
    new bool Equals(Discord.Models.IActivityTimestampsModel? other)
    {
        if(other is null) return false;
        
        return
            (this.Start.IsSpecified == other.Start.IsSpecified) && (!this.Start.IsSpecified || (EqualityComparer<System.DateTimeOffset>.Default.Equals(this.Start.Value, other.Start.Value))) &&
            (this.End.IsSpecified == other.End.IsSpecified) && (!this.End.IsSpecified || (EqualityComparer<System.DateTimeOffset>.Default.Equals(this.End.Value, other.End.Value)));
    }
    

    bool IEquatable<Discord.Models.IActivityTimestampsModel>.Equals(Discord.Models.IActivityTimestampsModel? other) => Equals(other);
}
