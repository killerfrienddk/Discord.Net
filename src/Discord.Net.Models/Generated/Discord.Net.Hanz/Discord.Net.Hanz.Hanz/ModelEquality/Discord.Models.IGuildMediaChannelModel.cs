using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IGuildMediaChannelModel : 
    IEquatable<Discord.Models.IGuildMediaChannelModel>
{
    new bool Equals(Discord.Models.IGuildMediaChannelModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<bool>.Default.Equals(this.IsNsfw, other.IsNsfw) &&
            EqualityComparer<string?>.Default.Equals(this.Topic, other.Topic) &&
            (this.RatelimitPerUser.IsSpecified == other.RatelimitPerUser.IsSpecified) && (!this.RatelimitPerUser.IsSpecified || (EqualityComparer<int>.Default.Equals(this.RatelimitPerUser.Value, other.RatelimitPerUser.Value))) &&
            (this.DefaultReactionEmoji.IsSpecified == other.DefaultReactionEmoji.IsSpecified) && (!this.DefaultReactionEmoji.IsSpecified || (EqualityComparer<Discord.DiscordEmojiId?>.Default.Equals(this.DefaultReactionEmoji.Value, other.DefaultReactionEmoji.Value))) &&
            EqualityComparer<System.Collections.Generic.IEnumerable<Discord.Models.ITagModel>>.Default.Equals(this.AvailableTags, other.AvailableTags) &&
            EqualityComparer<int?>.Default.Equals(this.DefaultSortOrder, other.DefaultSortOrder) &&
            EqualityComparer<int>.Default.Equals(this.DefaultAutoArchiveDuration, other.DefaultAutoArchiveDuration) &&
            (this.DefaultThreadRateLimitPerUser.IsSpecified == other.DefaultThreadRateLimitPerUser.IsSpecified) && (!this.DefaultThreadRateLimitPerUser.IsSpecified || (EqualityComparer<int>.Default.Equals(this.DefaultThreadRateLimitPerUser.Value, other.DefaultThreadRateLimitPerUser.Value))) &&
            EqualityComparer<string>.Default.Equals(this.Name, other.Name) &&
            EqualityComparer<ulong>.Default.Equals(this.GuildId, other.GuildId) &&
            (this.ParentId.IsSpecified == other.ParentId.IsSpecified) && (!this.ParentId.IsSpecified || (EqualityComparer<ulong?>.Default.Equals(this.ParentId.Value, other.ParentId.Value))) &&
            EqualityComparer<int>.Default.Equals(this.Position, other.Position) &&
            EqualityComparer<System.Collections.Generic.IReadOnlyCollection<Discord.Models.IOverwriteModel>>.Default.Equals(this.PermissionOverwrites, other.PermissionOverwrites) &&
            (this.Flags.IsSpecified == other.Flags.IsSpecified) && (!this.Flags.IsSpecified || (EqualityComparer<int>.Default.Equals(this.Flags.Value, other.Flags.Value))) &&
            EqualityComparer<int>.Default.Equals(this.Type, other.Type);
    }
    

    bool IEquatable<Discord.Models.IGuildMediaChannelModel>.Equals(Discord.Models.IGuildMediaChannelModel? other) => Equals(other);

    bool IEquatable<Discord.Models.IThreadableChannelModel>.Equals(Discord.Models.IThreadableChannelModel? other) => other is Discord.Models.IGuildMediaChannelModel self && Equals(self);

    bool Discord.Models.IThreadableChannelModel.Equals(Discord.Models.IThreadableChannelModel? other) => other is Discord.Models.IGuildMediaChannelModel self && Equals(self);

    bool IEquatable<Discord.Models.IGuildChannelModel>.Equals(Discord.Models.IGuildChannelModel? other) => other is Discord.Models.IGuildMediaChannelModel self && Equals(self);

    bool Discord.Models.IGuildChannelModel.Equals(Discord.Models.IGuildChannelModel? other) => other is Discord.Models.IGuildMediaChannelModel self && Equals(self);

    bool IEquatable<Discord.Models.IChannelModel>.Equals(Discord.Models.IChannelModel? other) => other is Discord.Models.IGuildMediaChannelModel self && Equals(self);

    bool Discord.Models.IChannelModel.Equals(Discord.Models.IChannelModel? other) => other is Discord.Models.IGuildMediaChannelModel self && Equals(self);
}
