using Discord.Models.Json;

namespace Discord.Models;

public partial interface IMessageModel : IEquatable<IMessageModel>
{
    new bool Equals(Discord.Models.IMessageModel? other)
    {
        if (other is null)
            return false;
        return this.AuthorId.Equals(this.AuthorId) && this.ChannelId.Equals(this.ChannelId) && (this.WebhookId?.Equals(this.WebhookId) ?? this.WebhookId is not null) && (this.Content?.Equals(this.Content) ?? this.Content is not null) && this.Timestamp.Equals(this.Timestamp) && (this.EditedTimestamp?.Equals(this.EditedTimestamp) ?? this.EditedTimestamp is not null) && this.IsTTS.Equals(this.IsTTS) && this.MentionsEveryone.Equals(this.MentionsEveryone) && this.MentionedUsers.Equals(this.MentionedUsers) && this.MentionedRoles.Equals(this.MentionedRoles) && this.MentionedChannels.Equals(this.MentionedChannels) && this.Attachments.Equals(this.Attachments) && this.Embeds.Equals(this.Embeds) && this.Reactions.Equals(this.Reactions) && this.IsPinned.Equals(this.IsPinned) && this.IsWebhook.Equals(this.IsWebhook) && this.Type.Equals(this.Type) && (this.Activity?.Equals(this.Activity) ?? this.Activity is not null) && (this.Application?.Equals(this.Application) ?? this.Application is not null) && (this.MessageReference?.Equals(this.MessageReference) ?? this.MessageReference is not null) && this.Flags.Equals(this.Flags) && (this.InteractionMetadata?.Equals(this.InteractionMetadata) ?? this.InteractionMetadata is not null) && (this.ThreadId?.Equals(this.ThreadId) ?? this.ThreadId is not null) && (this.ThreadGuildId?.Equals(this.ThreadGuildId) ?? this.ThreadGuildId is not null) && this.Components.Equals(this.Components) && this.Stickers.Equals(this.Stickers) && (this.Position?.Equals(this.Position) ?? this.Position is not null) && (this.RoleSubscriptionData?.Equals(this.RoleSubscriptionData) ?? this.RoleSubscriptionData is not null) && (this.Poll?.Equals(this.Poll) ?? this.Poll is not null);
    }

    bool IEquatable<IMessageModel>.Equals(IMessageModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IMessageModel otherThis && Equals(otherThis);
}