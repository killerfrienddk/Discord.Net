using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IMessageReferenceModel : 
    IEquatable<Discord.Models.IMessageReferenceModel>
{
    new bool Equals(Discord.Models.IMessageReferenceModel? other)
    {
        if(other is null) return false;
        
        return
            (this.Type.IsSpecified == other.Type.IsSpecified) && (!this.Type.IsSpecified || (EqualityComparer<int>.Default.Equals(this.Type.Value, other.Type.Value))) &&
            (this.MessageId.IsSpecified == other.MessageId.IsSpecified) && (!this.MessageId.IsSpecified || (EqualityComparer<ulong>.Default.Equals(this.MessageId.Value, other.MessageId.Value))) &&
            (this.ChannelId.IsSpecified == other.ChannelId.IsSpecified) && (!this.ChannelId.IsSpecified || (EqualityComparer<ulong>.Default.Equals(this.ChannelId.Value, other.ChannelId.Value))) &&
            (this.GuildId.IsSpecified == other.GuildId.IsSpecified) && (!this.GuildId.IsSpecified || (EqualityComparer<ulong>.Default.Equals(this.GuildId.Value, other.GuildId.Value))) &&
            (this.FailIfNotExist.IsSpecified == other.FailIfNotExist.IsSpecified) && (!this.FailIfNotExist.IsSpecified || (EqualityComparer<bool>.Default.Equals(this.FailIfNotExist.Value, other.FailIfNotExist.Value)));
    }
    

    bool IEquatable<Discord.Models.IMessageReferenceModel>.Equals(Discord.Models.IMessageReferenceModel? other) => Equals(other);
}
