using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface ITeamModel : 
    IEquatable<Discord.Models.ITeamModel>
{
    new bool Equals(Discord.Models.ITeamModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<string?>.Default.Equals(this.Icon, other.Icon) &&
            EqualityComparer<System.Collections.Generic.IReadOnlyCollection<Discord.Models.ModelOrId<Discord.Models.ITeamMemberModel, ulong>>>.Default.Equals(this.Members, other.Members) &&
            EqualityComparer<string>.Default.Equals(this.Name, other.Name) &&
            EqualityComparer<ulong>.Default.Equals(this.OwnerId, other.OwnerId);
    }
    

    bool IEquatable<Discord.Models.ITeamModel>.Equals(Discord.Models.ITeamModel? other) => Equals(other);
}
