using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IMessageSnapshotMessageModel : 
    IEquatable<Discord.Models.IMessageSnapshotMessageModel>
{
    new bool Equals(Discord.Models.IMessageSnapshotMessageModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<int>.Default.Equals(this.Type, other.Type) &&
            EqualityComparer<string>.Default.Equals(this.Content, other.Content) &&
            EqualityComparer<System.Collections.Generic.IReadOnlyCollection<Discord.Models.IEmbedModel>>.Default.Equals(this.Embeds, other.Embeds) &&
            EqualityComparer<System.Collections.Generic.IReadOnlyCollection<Discord.Models.IAttachmentModel>>.Default.Equals(this.Attachments, other.Attachments) &&
            EqualityComparer<System.DateTimeOffset>.Default.Equals(this.Timestamp, other.Timestamp) &&
            EqualityComparer<System.DateTimeOffset?>.Default.Equals(this.EditedTimestamp, other.EditedTimestamp) &&
            (this.Flags.IsSpecified == other.Flags.IsSpecified) && (!this.Flags.IsSpecified || (EqualityComparer<int>.Default.Equals(this.Flags.Value, other.Flags.Value))) &&
            EqualityComparer<System.Collections.Generic.IReadOnlyCollection<Discord.Models.ModelOrId<Discord.Models.IUserModel, ulong>>>.Default.Equals(this.Mentions, other.Mentions) &&
            EqualityComparer<System.Collections.Generic.IReadOnlyCollection<ulong>>.Default.Equals(this.MentionedRoles, other.MentionedRoles) &&
            EqualityComparer<System.Collections.Generic.IReadOnlyCollection<Discord.Models.ModelOrId<Discord.Models.IStickerItemModel, ulong>>>.Default.Equals(this.StickerItems, other.StickerItems) &&
            EqualityComparer<System.Collections.Generic.IReadOnlyCollection<Discord.Models.IMessageComponentModel>>.Default.Equals(this.Components, other.Components);
    }
    

    bool IEquatable<Discord.Models.IMessageSnapshotMessageModel>.Equals(Discord.Models.IMessageSnapshotMessageModel? other) => Equals(other);
}
