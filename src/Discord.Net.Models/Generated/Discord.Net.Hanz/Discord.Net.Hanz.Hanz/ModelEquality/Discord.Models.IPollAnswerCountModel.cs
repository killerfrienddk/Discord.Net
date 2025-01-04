using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IPollAnswerCountModel : 
    IEquatable<Discord.Models.IPollAnswerCountModel>
{
    new bool Equals(Discord.Models.IPollAnswerCountModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<int>.Default.Equals(this.Id, other.Id) &&
            EqualityComparer<int>.Default.Equals(this.Count, other.Count) &&
            EqualityComparer<bool>.Default.Equals(this.MeVoted, other.MeVoted);
    }
    

    bool IEquatable<Discord.Models.IPollAnswerCountModel>.Equals(Discord.Models.IPollAnswerCountModel? other) => Equals(other);
}
