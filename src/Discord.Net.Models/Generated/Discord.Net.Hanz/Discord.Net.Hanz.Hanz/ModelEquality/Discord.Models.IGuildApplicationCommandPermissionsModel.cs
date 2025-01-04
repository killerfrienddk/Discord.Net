using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IGuildApplicationCommandPermissionsModel : 
    IEquatable<Discord.Models.IGuildApplicationCommandPermissionsModel>
{
    new bool Equals(Discord.Models.IGuildApplicationCommandPermissionsModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<ulong>.Default.Equals(this.ApplicationId, other.ApplicationId) &&
            EqualityComparer<ulong>.Default.Equals(this.GuildId, other.GuildId) &&
            EqualityComparer<System.Collections.Generic.IReadOnlyCollection<Discord.Models.IApplicationCommandPermission>>.Default.Equals(this.Permissions, other.Permissions);
    }
    

    bool IEquatable<Discord.Models.IGuildApplicationCommandPermissionsModel>.Equals(Discord.Models.IGuildApplicationCommandPermissionsModel? other) => Equals(other);
}
