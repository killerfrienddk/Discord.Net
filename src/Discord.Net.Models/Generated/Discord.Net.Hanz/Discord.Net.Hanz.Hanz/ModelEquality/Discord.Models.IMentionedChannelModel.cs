using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IMentionedChannelModel : 
    IEquatable<Discord.Models.IMentionedChannelModel>
{
    new bool Equals(Discord.Models.IMentionedChannelModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<ulong>.Default.Equals(this.Id, other.Id) &&
            EqualityComparer<ulong>.Default.Equals(this.GuildId, other.GuildId) &&
            EqualityComparer<int>.Default.Equals(this.Type, other.Type) &&
            EqualityComparer<string>.Default.Equals(this.Name, other.Name);
    }
    

    bool IEquatable<Discord.Models.IMentionedChannelModel>.Equals(Discord.Models.IMentionedChannelModel? other) => Equals(other);
}
