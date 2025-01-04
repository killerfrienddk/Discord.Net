using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IBanModel : 
    IEquatable<Discord.Models.IBanModel>
{
    new bool Equals(Discord.Models.IBanModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<string?>.Default.Equals(this.Reason, other.Reason) &&
            EqualityComparer<ulong>.Default.Equals(this.UserId, other.UserId);
    }
    

    bool IEquatable<Discord.Models.IBanModel>.Equals(Discord.Models.IBanModel? other) => Equals(other);
}
