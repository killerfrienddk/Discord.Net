using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IPollAnswerModel : 
    IEquatable<Discord.Models.IPollAnswerModel>
{
    new bool Equals(Discord.Models.IPollAnswerModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<Discord.Models.IPollMediaModel>.Default.Equals(this.Media, other.Media);
    }
    

    bool IEquatable<Discord.Models.IPollAnswerModel>.Equals(Discord.Models.IPollAnswerModel? other) => Equals(other);
}
