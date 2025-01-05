using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IActivityModel : 
    IEquatable<Discord.Models.IActivityModel>
{
    new bool Equals(Discord.Models.IActivityModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<string>.Default.Equals(this.Name, other.Name) &&
            EqualityComparer<int>.Default.Equals(this.Type, other.Type) &&
            (this.Url.IsSpecified == other.Url.IsSpecified) && (!this.Url.IsSpecified || (EqualityComparer<string?>.Default.Equals(this.Url.Value, other.Url.Value))) &&
            EqualityComparer<System.DateTimeOffset>.Default.Equals(this.CreatedAt, other.CreatedAt) &&
            (this.Timestamps.IsSpecified == other.Timestamps.IsSpecified) && (!this.Timestamps.IsSpecified || (EqualityComparer<Discord.Models.IActivityTimestampsModel>.Default.Equals(this.Timestamps.Value, other.Timestamps.Value))) &&
            (this.ApplicationId.IsSpecified == other.ApplicationId.IsSpecified) && (!this.ApplicationId.IsSpecified || (EqualityComparer<ulong>.Default.Equals(this.ApplicationId.Value, other.ApplicationId.Value))) &&
            (this.Details.IsSpecified == other.Details.IsSpecified) && (!this.Details.IsSpecified || (EqualityComparer<string?>.Default.Equals(this.Details.Value, other.Details.Value))) &&
            (this.State.IsSpecified == other.State.IsSpecified) && (!this.State.IsSpecified || (EqualityComparer<string?>.Default.Equals(this.State.Value, other.State.Value))) &&
            (this.Emoji.IsSpecified == other.Emoji.IsSpecified) && (!this.Emoji.IsSpecified || (EqualityComparer<Discord.DiscordEmojiId?>.Default.Equals(this.Emoji.Value, other.Emoji.Value))) &&
            (this.Party.IsSpecified == other.Party.IsSpecified) && (!this.Party.IsSpecified || (EqualityComparer<Discord.Models.IActivityPartyModel>.Default.Equals(this.Party.Value, other.Party.Value))) &&
            (this.Assets.IsSpecified == other.Assets.IsSpecified) && (!this.Assets.IsSpecified || (EqualityComparer<Discord.Models.IActivityAssetsModel>.Default.Equals(this.Assets.Value, other.Assets.Value))) &&
            (this.Secrets.IsSpecified == other.Secrets.IsSpecified) && (!this.Secrets.IsSpecified || (EqualityComparer<Discord.Models.IActivitySecretsModel>.Default.Equals(this.Secrets.Value, other.Secrets.Value))) &&
            (this.IsInstance.IsSpecified == other.IsInstance.IsSpecified) && (!this.IsInstance.IsSpecified || (EqualityComparer<bool>.Default.Equals(this.IsInstance.Value, other.IsInstance.Value))) &&
            (this.Flags.IsSpecified == other.Flags.IsSpecified) && (!this.Flags.IsSpecified || (EqualityComparer<int>.Default.Equals(this.Flags.Value, other.Flags.Value))) &&
            (this.Buttons.IsSpecified == other.Buttons.IsSpecified) && (!this.Buttons.IsSpecified || (EqualityComparer<System.Collections.Generic.IReadOnlyCollection<Discord.Models.IActivityButtonModel>>.Default.Equals(this.Buttons.Value, other.Buttons.Value)));
    }
    

    bool IEquatable<Discord.Models.IActivityModel>.Equals(Discord.Models.IActivityModel? other) => Equals(other);
}
