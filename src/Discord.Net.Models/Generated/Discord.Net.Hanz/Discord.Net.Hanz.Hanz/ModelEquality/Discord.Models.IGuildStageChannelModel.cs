using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IGuildStageChannelModel : 
    IEquatable<Discord.Models.IGuildStageChannelModel>
{
    new bool Equals(Discord.Models.IGuildStageChannelModel? other)
    {
        if(other is null) return false;
        
        return
            (this.RatelimitPerUser.IsSpecified == other.RatelimitPerUser.IsSpecified) && (!this.RatelimitPerUser.IsSpecified || (EqualityComparer<int>.Default.Equals(this.RatelimitPerUser.Value, other.RatelimitPerUser.Value))) &&
            EqualityComparer<bool>.Default.Equals(this.IsNsfw, other.IsNsfw) &&
            EqualityComparer<string?>.Default.Equals(this.Topic, other.Topic) &&
            EqualityComparer<int>.Default.Equals(this.Bitrate, other.Bitrate) &&
            (this.UserLimit.IsSpecified == other.UserLimit.IsSpecified) && (!this.UserLimit.IsSpecified || (EqualityComparer<int>.Default.Equals(this.UserLimit.Value, other.UserLimit.Value))) &&
            EqualityComparer<string>.Default.Equals(this.Name, other.Name) &&
            EqualityComparer<ulong>.Default.Equals(this.GuildId, other.GuildId) &&
            (this.ParentId.IsSpecified == other.ParentId.IsSpecified) && (!this.ParentId.IsSpecified || (EqualityComparer<ulong?>.Default.Equals(this.ParentId.Value, other.ParentId.Value))) &&
            EqualityComparer<int>.Default.Equals(this.Position, other.Position) &&
            EqualityComparer<System.Collections.Generic.IReadOnlyCollection<Discord.Models.IOverwriteModel>>.Default.Equals(this.PermissionOverwrites, other.PermissionOverwrites) &&
            (this.Flags.IsSpecified == other.Flags.IsSpecified) && (!this.Flags.IsSpecified || (EqualityComparer<int>.Default.Equals(this.Flags.Value, other.Flags.Value))) &&
            (this.RTCRegion.IsSpecified == other.RTCRegion.IsSpecified) && (!this.RTCRegion.IsSpecified || (EqualityComparer<string?>.Default.Equals(this.RTCRegion.Value, other.RTCRegion.Value))) &&
            (this.VideoQualityMode.IsSpecified == other.VideoQualityMode.IsSpecified) && (!this.VideoQualityMode.IsSpecified || (EqualityComparer<int>.Default.Equals(this.VideoQualityMode.Value, other.VideoQualityMode.Value))) &&
            EqualityComparer<int>.Default.Equals(this.Type, other.Type);
    }
    

    bool IEquatable<Discord.Models.IGuildStageChannelModel>.Equals(Discord.Models.IGuildStageChannelModel? other) => Equals(other);

    bool IEquatable<Discord.Models.IGuildVoiceChannelModel>.Equals(Discord.Models.IGuildVoiceChannelModel? other) => other is Discord.Models.IGuildStageChannelModel self && Equals(self);

    bool Discord.Models.IGuildVoiceChannelModel.Equals(Discord.Models.IGuildVoiceChannelModel? other) => other is Discord.Models.IGuildStageChannelModel self && Equals(self);

    bool IEquatable<Discord.Models.IGuildChannelModel>.Equals(Discord.Models.IGuildChannelModel? other) => other is Discord.Models.IGuildStageChannelModel self && Equals(self);

    bool Discord.Models.IGuildChannelModel.Equals(Discord.Models.IGuildChannelModel? other) => other is Discord.Models.IGuildStageChannelModel self && Equals(self);

    bool IEquatable<Discord.Models.IAudioChannelModel>.Equals(Discord.Models.IAudioChannelModel? other) => other is Discord.Models.IGuildStageChannelModel self && Equals(self);

    bool Discord.Models.IAudioChannelModel.Equals(Discord.Models.IAudioChannelModel? other) => other is Discord.Models.IGuildStageChannelModel self && Equals(self);

    bool IEquatable<Discord.Models.IChannelModel>.Equals(Discord.Models.IChannelModel? other) => other is Discord.Models.IGuildStageChannelModel self && Equals(self);

    bool Discord.Models.IChannelModel.Equals(Discord.Models.IChannelModel? other) => other is Discord.Models.IGuildStageChannelModel self && Equals(self);
}
