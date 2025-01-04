using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IDMChannelModel : 
    IEquatable<Discord.Models.IDMChannelModel>
{
    new bool Equals(Discord.Models.IDMChannelModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<Discord.Models.ModelOrId<Discord.Models.IUserModel, ulong>>.Default.Equals(this.Recipient, other.Recipient) &&
            EqualityComparer<int>.Default.Equals(this.Type, other.Type);
    }
    

    bool IEquatable<Discord.Models.IDMChannelModel>.Equals(Discord.Models.IDMChannelModel? other) => Equals(other);

    bool IEquatable<Discord.Models.IChannelModel>.Equals(Discord.Models.IChannelModel? other) => other is Discord.Models.IDMChannelModel self && Equals(self);

    bool Discord.Models.IChannelModel.Equals(Discord.Models.IChannelModel? other) => other is Discord.Models.IDMChannelModel self && Equals(self);
}
