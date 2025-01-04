using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IChannelModel : 
    IEquatable<Discord.Models.IChannelModel>
{
    new bool Equals(Discord.Models.IChannelModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<int>.Default.Equals(this.Type, other.Type);
    }
    

    bool IEquatable<Discord.Models.IChannelModel>.Equals(Discord.Models.IChannelModel? other) => Equals(other);
}
