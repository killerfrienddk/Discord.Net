using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IInviteModel : 
    IEquatable<Discord.Models.IInviteModel>
{
    new bool Equals(Discord.Models.IInviteModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<int>.Default.Equals(this.Type, other.Type) &&
            EqualityComparer<string>.Default.Equals(this.Code, other.Code) &&
            (this.Guild.IsSpecified == other.Guild.IsSpecified) && (!this.Guild.IsSpecified || (EqualityComparer<Discord.Models.ModelOrId<IPartialGuildModel, ulong>>.Default.Equals(this.Guild.Value, other.Guild.Value))) &&
            EqualityComparer<Discord.Models.ModelOrId<IPartialChannelModel, ulong>?>.Default.Equals(this.ChannelId, other.ChannelId) &&
            (this.Inviter.IsSpecified == other.Inviter.IsSpecified) && (!this.Inviter.IsSpecified || (EqualityComparer<Discord.Models.ModelOrId<Discord.Models.IUserModel, ulong>>.Default.Equals(this.Inviter.Value, other.Inviter.Value))) &&
            (this.TargetType.IsSpecified == other.TargetType.IsSpecified) && (!this.TargetType.IsSpecified || (EqualityComparer<int>.Default.Equals(this.TargetType.Value, other.TargetType.Value))) &&
            (this.TargetUser.IsSpecified == other.TargetUser.IsSpecified) && (!this.TargetUser.IsSpecified || (EqualityComparer<Discord.Models.ModelOrId<Discord.Models.IUserModel, ulong>>.Default.Equals(this.TargetUser.Value, other.TargetUser.Value))) &&
            (this.TargetApplication.IsSpecified == other.TargetApplication.IsSpecified) && (!this.TargetApplication.IsSpecified || (EqualityComparer<Discord.Models.ModelOrId<IPartialApplicationModel, ulong>>.Default.Equals(this.TargetApplication.Value, other.TargetApplication.Value))) &&
            (this.ApproximatePresenceCount.IsSpecified == other.ApproximatePresenceCount.IsSpecified) && (!this.ApproximatePresenceCount.IsSpecified || (EqualityComparer<int>.Default.Equals(this.ApproximatePresenceCount.Value, other.ApproximatePresenceCount.Value))) &&
            (this.ApproximateMemberCount.IsSpecified == other.ApproximateMemberCount.IsSpecified) && (!this.ApproximateMemberCount.IsSpecified || (EqualityComparer<int>.Default.Equals(this.ApproximateMemberCount.Value, other.ApproximateMemberCount.Value))) &&
            (this.ExpiresAt.IsSpecified == other.ExpiresAt.IsSpecified) && (!this.ExpiresAt.IsSpecified || (EqualityComparer<System.DateTimeOffset?>.Default.Equals(this.ExpiresAt.Value, other.ExpiresAt.Value))) &&
            (this.GuildScheduledEvent.IsSpecified == other.GuildScheduledEvent.IsSpecified) && (!this.GuildScheduledEvent.IsSpecified || (EqualityComparer<Discord.Models.ModelOrId<Discord.Models.IGuildScheduledEventModel, ulong>>.Default.Equals(this.GuildScheduledEvent.Value, other.GuildScheduledEvent.Value)));
    }
    

    bool IEquatable<Discord.Models.IInviteModel>.Equals(Discord.Models.IInviteModel? other) => Equals(other);
}
