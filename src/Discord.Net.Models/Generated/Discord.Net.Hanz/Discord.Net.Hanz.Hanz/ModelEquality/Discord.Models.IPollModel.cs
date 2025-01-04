using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IPollModel : 
    IEquatable<Discord.Models.IPollModel>
{
    new bool Equals(Discord.Models.IPollModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<Discord.Models.IPollMediaModel>.Default.Equals(this.Question, other.Question) &&
            EqualityComparer<System.Collections.Generic.IReadOnlyCollection<Discord.Models.IPollAnswerModel>>.Default.Equals(this.Answers, other.Answers) &&
            EqualityComparer<System.DateTimeOffset?>.Default.Equals(this.Expiry, other.Expiry) &&
            EqualityComparer<bool>.Default.Equals(this.AllowMultiselect, other.AllowMultiselect) &&
            EqualityComparer<int>.Default.Equals(this.LayoutType, other.LayoutType) &&
            (this.Results.IsSpecified == other.Results.IsSpecified) && (!this.Results.IsSpecified || (EqualityComparer<Discord.Models.IPollResultModel>.Default.Equals(this.Results.Value, other.Results.Value)));
    }
    

    bool IEquatable<Discord.Models.IPollModel>.Equals(Discord.Models.IPollModel? other) => Equals(other);
}
