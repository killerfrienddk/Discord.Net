using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IPollResultModel : 
    IEquatable<Discord.Models.IPollResultModel>
{
    new bool Equals(Discord.Models.IPollResultModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<bool>.Default.Equals(this.IsFinalized, other.IsFinalized) &&
            EqualityComparer<System.Collections.Generic.IReadOnlyCollection<Discord.Models.IPollAnswerCountModel>>.Default.Equals(this.AnswerCounts, other.AnswerCounts);
    }
    

    bool IEquatable<Discord.Models.IPollResultModel>.Equals(Discord.Models.IPollResultModel? other) => Equals(other);
}
