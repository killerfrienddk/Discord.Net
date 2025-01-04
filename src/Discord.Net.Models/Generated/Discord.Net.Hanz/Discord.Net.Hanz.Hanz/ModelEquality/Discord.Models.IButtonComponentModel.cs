using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IButtonComponentModel : 
    IEquatable<Discord.Models.IButtonComponentModel>
{
    new bool Equals(Discord.Models.IButtonComponentModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<int>.Default.Equals(this.Style, other.Style) &&
            (this.Label.IsSpecified == other.Label.IsSpecified) && (!this.Label.IsSpecified || (EqualityComparer<string>.Default.Equals(this.Label.Value, other.Label.Value))) &&
            (this.Emote.IsSpecified == other.Emote.IsSpecified) && (!this.Emote.IsSpecified || (EqualityComparer<Discord.DiscordEmojiId>.Default.Equals(this.Emote.Value, other.Emote.Value))) &&
            (this.CustomId.IsSpecified == other.CustomId.IsSpecified) && (!this.CustomId.IsSpecified || (EqualityComparer<string>.Default.Equals(this.CustomId.Value, other.CustomId.Value))) &&
            (this.SkuId.IsSpecified == other.SkuId.IsSpecified) && (!this.SkuId.IsSpecified || (EqualityComparer<ulong>.Default.Equals(this.SkuId.Value, other.SkuId.Value))) &&
            (this.Url.IsSpecified == other.Url.IsSpecified) && (!this.Url.IsSpecified || (EqualityComparer<string>.Default.Equals(this.Url.Value, other.Url.Value))) &&
            (this.IsDisabled.IsSpecified == other.IsDisabled.IsSpecified) && (!this.IsDisabled.IsSpecified || (EqualityComparer<bool>.Default.Equals(this.IsDisabled.Value, other.IsDisabled.Value))) &&
            EqualityComparer<int>.Default.Equals(this.Type, other.Type);
    }
    

    bool IEquatable<Discord.Models.IButtonComponentModel>.Equals(Discord.Models.IButtonComponentModel? other) => Equals(other);

    bool IEquatable<Discord.Models.IMessageComponentModel>.Equals(Discord.Models.IMessageComponentModel? other) => other is Discord.Models.IButtonComponentModel self && Equals(self);

    bool Discord.Models.IMessageComponentModel.Equals(Discord.Models.IMessageComponentModel? other) => other is Discord.Models.IButtonComponentModel self && Equals(self);
}
