using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IStageInstanceModel : 
    IEquatable<Discord.Models.IStageInstanceModel>
{
    new bool Equals(Discord.Models.IStageInstanceModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<ulong>.Default.Equals(this.GuildId, other.GuildId) &&
            EqualityComparer<ulong>.Default.Equals(this.ChannelId, other.ChannelId) &&
            EqualityComparer<string>.Default.Equals(this.Topic, other.Topic) &&
            EqualityComparer<int>.Default.Equals(this.PrivacyLevel, other.PrivacyLevel) &&
            EqualityComparer<bool>.Default.Equals(this.DiscoverableDisabled, other.DiscoverableDisabled) &&
            EqualityComparer<ulong?>.Default.Equals(this.GuildScheduledEventId, other.GuildScheduledEventId);
    }
    

    bool IEquatable<Discord.Models.IStageInstanceModel>.Equals(Discord.Models.IStageInstanceModel? other) => Equals(other);
}
