using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IGuildScheduledEventUserModel : 
    IEquatable<Discord.Models.IGuildScheduledEventUserModel>
{
    new bool Equals(Discord.Models.IGuildScheduledEventUserModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<ulong>.Default.Equals(this.GuildScheduledEventId, other.GuildScheduledEventId) &&
            EqualityComparer<ulong>.Default.Equals(this.UserId, other.UserId);
    }
    

    bool IEquatable<Discord.Models.IGuildScheduledEventUserModel>.Equals(Discord.Models.IGuildScheduledEventUserModel? other) => Equals(other);
}
