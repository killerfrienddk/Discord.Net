using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IPresenceModel : 
    IEquatable<Discord.Models.IPresenceModel>
{
    new bool Equals(Discord.Models.IPresenceModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<Discord.Models.ModelOrId<IPartialUserModel, ulong>>.Default.Equals(this.User, other.User) &&
            EqualityComparer<ulong>.Default.Equals(this.GuildId, other.GuildId) &&
            EqualityComparer<string>.Default.Equals(this.Status, other.Status) &&
            EqualityComparer<System.Collections.Generic.IReadOnlyCollection<Discord.Models.IActivityModel>>.Default.Equals(this.Activities, other.Activities) &&
            EqualityComparer<Discord.Models.IClientStatusModel>.Default.Equals(this.ClientStatus, other.ClientStatus);
    }
    

    bool IEquatable<Discord.Models.IPresenceModel>.Equals(Discord.Models.IPresenceModel? other) => Equals(other);
}
