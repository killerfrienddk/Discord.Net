using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IActivityButtonModel : 
    IEquatable<Discord.Models.IActivityButtonModel>
{
    new bool Equals(Discord.Models.IActivityButtonModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<string>.Default.Equals(this.Label, other.Label) &&
            EqualityComparer<string>.Default.Equals(this.Url, other.Url);
    }
    

    bool IEquatable<Discord.Models.IActivityButtonModel>.Equals(Discord.Models.IActivityButtonModel? other) => Equals(other);
}
