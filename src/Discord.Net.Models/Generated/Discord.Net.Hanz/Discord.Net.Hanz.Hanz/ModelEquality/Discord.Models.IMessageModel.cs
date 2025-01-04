using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IMessageModel : 
    IEquatable<Discord.Models.IMessageModel>
{
    new bool Equals(Discord.Models.IMessageModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<ulong>.Default.Equals(this.ChannelId, other.ChannelId) &&
            EqualityComparer<Discord.Models.ModelOrId<Discord.Models.IUserModel, ulong>>.Default.Equals(this.Author, other.Author) &&
            EqualityComparer<string>.Default.Equals(this.Content, other.Content) &&
            EqualityComparer<System.DateTimeOffset>.Default.Equals(this.Timestamp, other.Timestamp) &&
            EqualityComparer<System.DateTimeOffset?>.Default.Equals(this.EditedTimestamp, other.EditedTimestamp) &&
            EqualityComparer<bool>.Default.Equals(this.IsTTS, other.IsTTS) &&
            EqualityComparer<bool>.Default.Equals(this.MentionsEveryone, other.MentionsEveryone) &&
            EqualityComparer<System.Collections.Generic.IReadOnlyCollection<Discord.Models.ModelOrId<Discord.Models.IUserModel, ulong>>>.Default.Equals(this.Mentions, other.Mentions) &&
            EqualityComparer<System.Collections.Generic.IReadOnlyCollection<ulong>>.Default.Equals(this.MentionedRoles, other.MentionedRoles) &&
            EqualityComparer<System.Collections.Generic.IReadOnlyCollection<Discord.Models.IMentionedChannelModel>>.Default.Equals(this.MentionedChannels, other.MentionedChannels) &&
            EqualityComparer<System.Collections.Generic.IReadOnlyCollection<Discord.Models.IAttachmentModel>>.Default.Equals(this.Attachments, other.Attachments) &&
            EqualityComparer<System.Collections.Generic.IReadOnlyCollection<Discord.Models.IEmbedModel>>.Default.Equals(this.Embeds, other.Embeds) &&
            EqualityComparer<System.Collections.Generic.IReadOnlyCollection<Discord.Models.IReactionModel>>.Default.Equals(this.Reactions, other.Reactions) &&
            (this.Nonce.IsSpecified == other.Nonce.IsSpecified) && (!this.Nonce.IsSpecified || (EqualityComparer<string>.Default.Equals(this.Nonce.Value, other.Nonce.Value))) &&
            EqualityComparer<bool>.Default.Equals(this.IsPinned, other.IsPinned) &&
            (this.WebhookId.IsSpecified == other.WebhookId.IsSpecified) && (!this.WebhookId.IsSpecified || (EqualityComparer<ulong>.Default.Equals(this.WebhookId.Value, other.WebhookId.Value))) &&
            EqualityComparer<int>.Default.Equals(this.Type, other.Type) &&
            (this.Activity.IsSpecified == other.Activity.IsSpecified) && (!this.Activity.IsSpecified || (EqualityComparer<Discord.Models.IMessageActivityModel>.Default.Equals(this.Activity.Value, other.Activity.Value))) &&
            (this.Application.IsSpecified == other.Application.IsSpecified) && (!this.Application.IsSpecified || (EqualityComparer<IPartialApplicationModel>.Default.Equals(this.Application.Value, other.Application.Value))) &&
            (this.ApplicationId.IsSpecified == other.ApplicationId.IsSpecified) && (!this.ApplicationId.IsSpecified || (EqualityComparer<ulong>.Default.Equals(this.ApplicationId.Value, other.ApplicationId.Value))) &&
            (this.Flags.IsSpecified == other.Flags.IsSpecified) && (!this.Flags.IsSpecified || (EqualityComparer<int>.Default.Equals(this.Flags.Value, other.Flags.Value))) &&
            (this.MessageReference.IsSpecified == other.MessageReference.IsSpecified) && (!this.MessageReference.IsSpecified || (EqualityComparer<Discord.Models.IMessageReferenceModel>.Default.Equals(this.MessageReference.Value, other.MessageReference.Value))) &&
            (this.MessageSnapshots.IsSpecified == other.MessageSnapshots.IsSpecified) && (!this.MessageSnapshots.IsSpecified || (EqualityComparer<System.Collections.Generic.IReadOnlyCollection<Discord.Models.IMessageSnapshotModel>>.Default.Equals(this.MessageSnapshots.Value, other.MessageSnapshots.Value))) &&
            (this.ReferencedMessage.IsSpecified == other.ReferencedMessage.IsSpecified) && (!this.ReferencedMessage.IsSpecified || (EqualityComparer<Discord.Models.ModelOrId<Discord.Models.IMessageModel, ulong>?>.Default.Equals(this.ReferencedMessage.Value, other.ReferencedMessage.Value))) &&
            (this.InteractionMetadata.IsSpecified == other.InteractionMetadata.IsSpecified) && (!this.InteractionMetadata.IsSpecified || (EqualityComparer<Discord.Models.IMessageInteractionMetadataModel>.Default.Equals(this.InteractionMetadata.Value, other.InteractionMetadata.Value))) &&
            (this.Thread.IsSpecified == other.Thread.IsSpecified) && (!this.Thread.IsSpecified || (EqualityComparer<Discord.Models.ModelOrId<Discord.Models.IThreadChannelModel, ulong>>.Default.Equals(this.Thread.Value, other.Thread.Value))) &&
            (this.Components.IsSpecified == other.Components.IsSpecified) && (!this.Components.IsSpecified || (EqualityComparer<System.Collections.Generic.IReadOnlyCollection<Discord.Models.IMessageComponentModel>>.Default.Equals(this.Components.Value, other.Components.Value))) &&
            (this.StickerItems.IsSpecified == other.StickerItems.IsSpecified) && (!this.StickerItems.IsSpecified || (EqualityComparer<System.Collections.Generic.IReadOnlyCollection<Discord.Models.IStickerItemModel>>.Default.Equals(this.StickerItems.Value, other.StickerItems.Value))) &&
            (this.Position.IsSpecified == other.Position.IsSpecified) && (!this.Position.IsSpecified || (EqualityComparer<int>.Default.Equals(this.Position.Value, other.Position.Value))) &&
            (this.RoleSubscriptionData.IsSpecified == other.RoleSubscriptionData.IsSpecified) && (!this.RoleSubscriptionData.IsSpecified || (EqualityComparer<Discord.Models.IMessageRoleSubscriptionData>.Default.Equals(this.RoleSubscriptionData.Value, other.RoleSubscriptionData.Value))) &&
            (this.Resolved.IsSpecified == other.Resolved.IsSpecified) && (!this.Resolved.IsSpecified || (EqualityComparer<Discord.Models.IResolvedDataModel>.Default.Equals(this.Resolved.Value, other.Resolved.Value))) &&
            (this.Poll.IsSpecified == other.Poll.IsSpecified) && (!this.Poll.IsSpecified || (EqualityComparer<Discord.Models.IPollModel>.Default.Equals(this.Poll.Value, other.Poll.Value))) &&
            (this.Call.IsSpecified == other.Call.IsSpecified) && (!this.Call.IsSpecified || (EqualityComparer<Discord.Models.IMessageCallModel>.Default.Equals(this.Call.Value, other.Call.Value)));
    }
    

    bool IEquatable<Discord.Models.IMessageModel>.Equals(Discord.Models.IMessageModel? other) => Equals(other);
}
