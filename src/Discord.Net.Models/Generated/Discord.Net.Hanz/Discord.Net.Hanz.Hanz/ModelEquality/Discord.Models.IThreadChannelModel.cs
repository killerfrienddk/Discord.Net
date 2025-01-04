using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IThreadChannelModel : 
    IEquatable<Discord.Models.IThreadChannelModel>
{
    new bool Equals(Discord.Models.IThreadChannelModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<ulong>.Default.Equals(this.ParentId, other.ParentId) &&
            EqualityComparer<int>.Default.Equals(this.MemberCount, other.MemberCount) &&
            (this.MessageCount.IsSpecified == other.MessageCount.IsSpecified) && (!this.MessageCount.IsSpecified || (EqualityComparer<int>.Default.Equals(this.MessageCount.Value, other.MessageCount.Value))) &&
            (this.AppliedTags.IsSpecified == other.AppliedTags.IsSpecified) && (!this.AppliedTags.IsSpecified || ((this.AppliedTags.Value is null == other.AppliedTags.Value is null) && (this.AppliedTags.Value is null || this.AppliedTags.Value.SequenceEqual(other.AppliedTags.Value!)))) &&
            EqualityComparer<ulong>.Default.Equals(this.OwnerId, other.OwnerId) &&
            (this.RatelimitPerUser.IsSpecified == other.RatelimitPerUser.IsSpecified) && (!this.RatelimitPerUser.IsSpecified || (EqualityComparer<int>.Default.Equals(this.RatelimitPerUser.Value, other.RatelimitPerUser.Value))) &&
            EqualityComparer<bool>.Default.Equals(this.IsNsfw, other.IsNsfw) &&
            EqualityComparer<string?>.Default.Equals(this.Topic, other.Topic) &&
            EqualityComparer<Discord.Models.IThreadMetadataModel>.Default.Equals(this.Metadata, other.Metadata) &&
            EqualityComparer<string>.Default.Equals(this.Name, other.Name) &&
            EqualityComparer<ulong>.Default.Equals(this.GuildId, other.GuildId) &&
            (this.ParentId.IsSpecified == other.ParentId.IsSpecified) && (!this.ParentId.IsSpecified || (EqualityComparer<ulong?>.Default.Equals(this.ParentId.Value, other.ParentId.Value))) &&
            EqualityComparer<int>.Default.Equals(this.Position, other.Position) &&
            EqualityComparer<System.Collections.Generic.IReadOnlyCollection<Discord.Models.IOverwriteModel>>.Default.Equals(this.PermissionOverwrites, other.PermissionOverwrites) &&
            (this.Flags.IsSpecified == other.Flags.IsSpecified) && (!this.Flags.IsSpecified || (EqualityComparer<int>.Default.Equals(this.Flags.Value, other.Flags.Value))) &&
            EqualityComparer<int>.Default.Equals(this.Type, other.Type);
    }
    

    bool IEquatable<Discord.Models.IThreadChannelModel>.Equals(Discord.Models.IThreadChannelModel? other) => Equals(other);

    bool IEquatable<Discord.Models.IGuildChannelModel>.Equals(Discord.Models.IGuildChannelModel? other) => other is Discord.Models.IThreadChannelModel self && Equals(self);

    bool Discord.Models.IGuildChannelModel.Equals(Discord.Models.IGuildChannelModel? other) => other is Discord.Models.IThreadChannelModel self && Equals(self);

    bool IEquatable<Discord.Models.IChannelModel>.Equals(Discord.Models.IChannelModel? other) => other is Discord.Models.IThreadChannelModel self && Equals(self);

    bool Discord.Models.IChannelModel.Equals(Discord.Models.IChannelModel? other) => other is Discord.Models.IThreadChannelModel self && Equals(self);
}
