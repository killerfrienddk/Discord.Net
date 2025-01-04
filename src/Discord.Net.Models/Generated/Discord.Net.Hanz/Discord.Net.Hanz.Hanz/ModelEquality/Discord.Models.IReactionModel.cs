using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IReactionModel : 
    IEquatable<Discord.Models.IReactionModel>
{
    new bool Equals(Discord.Models.IReactionModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<int>.Default.Equals(this.Total, other.Total) &&
            EqualityComparer<int>.Default.Equals(this.BurstCount, other.BurstCount) &&
            EqualityComparer<int>.Default.Equals(this.NormalCount, other.NormalCount) &&
            EqualityComparer<bool>.Default.Equals(this.Me, other.Me) &&
            EqualityComparer<bool>.Default.Equals(this.MeBurst, other.MeBurst) &&
            (this.BurstColors is null == other.BurstColors is null) && (this.BurstColors is null || this.BurstColors.SequenceEqual(other.BurstColors!));
    }
    

    bool IEquatable<Discord.Models.IReactionModel>.Equals(Discord.Models.IReactionModel? other) => Equals(other);
}
