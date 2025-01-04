using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IOverwriteModel : 
    IEquatable<Discord.Models.IOverwriteModel>
{
    new bool Equals(Discord.Models.IOverwriteModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<ulong>.Default.Equals(this.TargetId, other.TargetId) &&
            EqualityComparer<int>.Default.Equals(this.Type, other.Type) &&
            EqualityComparer<string>.Default.Equals(this.Allow, other.Allow) &&
            EqualityComparer<string>.Default.Equals(this.Deny, other.Deny);
    }
    

    bool IEquatable<Discord.Models.IOverwriteModel>.Equals(Discord.Models.IOverwriteModel? other) => Equals(other);
}
