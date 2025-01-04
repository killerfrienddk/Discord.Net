using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IActivityInstanceModel : 
    IEquatable<Discord.Models.IActivityInstanceModel>
{
    new bool Equals(Discord.Models.IActivityInstanceModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<string>.Default.Equals(this.Id, other.Id);
    }
    

    bool IEquatable<Discord.Models.IActivityInstanceModel>.Equals(Discord.Models.IActivityInstanceModel? other) => Equals(other);
}
