using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IGuildScheduledEventModel : 
    IEquatable<Discord.Models.IGuildScheduledEventModel>
{
    new bool Equals(Discord.Models.IGuildScheduledEventModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<ulong>.Default.Equals(this.GuildId, other.GuildId) &&
            (this.ChannelId.IsSpecified == other.ChannelId.IsSpecified) && (!this.ChannelId.IsSpecified || (EqualityComparer<ulong?>.Default.Equals(this.ChannelId.Value, other.ChannelId.Value))) &&
            EqualityComparer<Discord.Models.ModelOrId<Discord.Models.IUserModel, ulong>>.Default.Equals(this.Creator, other.Creator) &&
            EqualityComparer<string>.Default.Equals(this.Name, other.Name) &&
            (this.Description.IsSpecified == other.Description.IsSpecified) && (!this.Description.IsSpecified || (EqualityComparer<string?>.Default.Equals(this.Description.Value, other.Description.Value))) &&
            EqualityComparer<System.DateTimeOffset>.Default.Equals(this.ScheduledStartTime, other.ScheduledStartTime) &&
            EqualityComparer<System.DateTimeOffset?>.Default.Equals(this.ScheduledEndTime, other.ScheduledEndTime) &&
            EqualityComparer<int>.Default.Equals(this.PrivacyLevel, other.PrivacyLevel) &&
            EqualityComparer<int>.Default.Equals(this.Status, other.Status) &&
            EqualityComparer<int>.Default.Equals(this.EntityType, other.EntityType) &&
            EqualityComparer<ulong?>.Default.Equals(this.EntityId, other.EntityId) &&
            EqualityComparer<Discord.Models.IGuildScheduledEventMetadataModel?>.Default.Equals(this.EntityMetadata, other.EntityMetadata) &&
            (this.UserCount.IsSpecified == other.UserCount.IsSpecified) && (!this.UserCount.IsSpecified || (EqualityComparer<int>.Default.Equals(this.UserCount.Value, other.UserCount.Value))) &&
            (this.Image.IsSpecified == other.Image.IsSpecified) && (!this.Image.IsSpecified || (EqualityComparer<string?>.Default.Equals(this.Image.Value, other.Image.Value))) &&
            EqualityComparer<Discord.Models.IGuildScheduledEventRecurrenceRuleModel?>.Default.Equals(this.RecurrenceRule, other.RecurrenceRule);
    }
    

    bool IEquatable<Discord.Models.IGuildScheduledEventModel>.Equals(Discord.Models.IGuildScheduledEventModel? other) => Equals(other);
}
