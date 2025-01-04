using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IGroupDMChannelModel : 
    IEquatable<Discord.Models.IGroupDMChannelModel>
{
    new bool Equals(Discord.Models.IGroupDMChannelModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<System.Collections.Generic.IReadOnlyCollection<Discord.Models.ModelOrId<Discord.Models.IUserModel, ulong>>>.Default.Equals(this.Recipients, other.Recipients) &&
            EqualityComparer<ulong>.Default.Equals(this.OwnerId, other.OwnerId) &&
            EqualityComparer<int>.Default.Equals(this.Type, other.Type);
    }
    

    bool IEquatable<Discord.Models.IGroupDMChannelModel>.Equals(Discord.Models.IGroupDMChannelModel? other) => Equals(other);

    bool IEquatable<Discord.Models.IChannelModel>.Equals(Discord.Models.IChannelModel? other) => other is Discord.Models.IGroupDMChannelModel self && Equals(self);

    bool Discord.Models.IChannelModel.Equals(Discord.Models.IChannelModel? other) => other is Discord.Models.IGroupDMChannelModel self && Equals(self);
}
