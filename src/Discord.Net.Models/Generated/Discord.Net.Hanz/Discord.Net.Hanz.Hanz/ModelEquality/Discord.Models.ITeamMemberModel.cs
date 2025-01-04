using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface ITeamMemberModel : 
    IEquatable<Discord.Models.ITeamMemberModel>
{
    new bool Equals(Discord.Models.ITeamMemberModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<int>.Default.Equals(this.MembershipState, other.MembershipState) &&
            EqualityComparer<ulong>.Default.Equals(this.TeamId, other.TeamId) &&
            EqualityComparer<string>.Default.Equals(this.Role, other.Role) &&
            EqualityComparer<Discord.Models.ModelOrId<IPartialUserModel, ulong>>.Default.Equals(this.User, other.User);
    }
    

    bool IEquatable<Discord.Models.ITeamMemberModel>.Equals(Discord.Models.ITeamMemberModel? other) => Equals(other);
}
