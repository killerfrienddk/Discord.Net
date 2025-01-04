using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IAudioChannelModel : 
    IEquatable<Discord.Models.IAudioChannelModel>
{
    new bool Equals(Discord.Models.IAudioChannelModel? other)
    {
        if(other is null) return false;
        
        return
            (this.RTCRegion.IsSpecified == other.RTCRegion.IsSpecified) && (!this.RTCRegion.IsSpecified || (EqualityComparer<string?>.Default.Equals(this.RTCRegion.Value, other.RTCRegion.Value))) &&
            (this.VideoQualityMode.IsSpecified == other.VideoQualityMode.IsSpecified) && (!this.VideoQualityMode.IsSpecified || (EqualityComparer<int>.Default.Equals(this.VideoQualityMode.Value, other.VideoQualityMode.Value))) &&
            EqualityComparer<int>.Default.Equals(this.Type, other.Type);
    }
    

    bool IEquatable<Discord.Models.IAudioChannelModel>.Equals(Discord.Models.IAudioChannelModel? other) => Equals(other);

    bool IEquatable<Discord.Models.IChannelModel>.Equals(Discord.Models.IChannelModel? other) => other is Discord.Models.IAudioChannelModel self && Equals(self);

    bool Discord.Models.IChannelModel.Equals(Discord.Models.IChannelModel? other) => other is Discord.Models.IAudioChannelModel self && Equals(self);
}
