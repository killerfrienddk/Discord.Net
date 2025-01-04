using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IVoiceStateModel : 
    IEquatable<Discord.Models.IVoiceStateModel>
{
    new bool Equals(Discord.Models.IVoiceStateModel? other)
    {
        if(other is null) return false;
        
        return
            (this.GuildId.IsSpecified == other.GuildId.IsSpecified) && (!this.GuildId.IsSpecified || (EqualityComparer<ulong>.Default.Equals(this.GuildId.Value, other.GuildId.Value))) &&
            EqualityComparer<ulong?>.Default.Equals(this.ChannelId, other.ChannelId) &&
            EqualityComparer<ulong>.Default.Equals(this.UserId, other.UserId) &&
            (this.Member.IsSpecified == other.Member.IsSpecified) && (!this.Member.IsSpecified || (EqualityComparer<Discord.Models.ModelOrId<Discord.Models.IMemberModel, ulong>>.Default.Equals(this.Member.Value, other.Member.Value))) &&
            EqualityComparer<string>.Default.Equals(this.SessionId, other.SessionId) &&
            EqualityComparer<bool>.Default.Equals(this.IsDeafened, other.IsDeafened) &&
            EqualityComparer<bool>.Default.Equals(this.IsMuted, other.IsMuted) &&
            EqualityComparer<bool>.Default.Equals(this.IsSelfDeafened, other.IsSelfDeafened) &&
            EqualityComparer<bool>.Default.Equals(this.IsSelfMuted, other.IsSelfMuted) &&
            (this.IsSelfStreaming.IsSpecified == other.IsSelfStreaming.IsSpecified) && (!this.IsSelfStreaming.IsSpecified || (EqualityComparer<bool>.Default.Equals(this.IsSelfStreaming.Value, other.IsSelfStreaming.Value))) &&
            EqualityComparer<bool>.Default.Equals(this.IsSelfVideo, other.IsSelfVideo) &&
            EqualityComparer<bool>.Default.Equals(this.IsSuppressed, other.IsSuppressed) &&
            EqualityComparer<System.DateTimeOffset?>.Default.Equals(this.RequestToSpeakTimestamp, other.RequestToSpeakTimestamp);
    }
    

    bool IEquatable<Discord.Models.IVoiceStateModel>.Equals(Discord.Models.IVoiceStateModel? other) => Equals(other);
}
