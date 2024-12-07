using System.Text.Json.Serialization;

namespace Discord.Models.Json;

public sealed partial class MessageCreatedUpdated : IExtendedModel<Discord.Models.Json.Message>
{
    Discord.Models.Json.Message IExtendedModel<Discord.Models.Json.Message>.ExtendedValue => Message;

    ulong Discord.Models.IMessageModel.AuthorId => (Message as Discord.Models.IMessageModel).AuthorId;

    ulong Discord.Models.IMessageModel.ChannelId => (Message as Discord.Models.IMessageModel).ChannelId;

    ulong? Discord.Models.IMessageModel.WebhookId => (Message as Discord.Models.IMessageModel).WebhookId;

    string? Discord.Models.IMessageModel.Content => (Message as Discord.Models.IMessageModel).Content;

    System.DateTimeOffset Discord.Models.IMessageModel.Timestamp => (Message as Discord.Models.IMessageModel).Timestamp;

    System.DateTimeOffset? Discord.Models.IMessageModel.EditedTimestamp => (Message as Discord.Models.IMessageModel).EditedTimestamp;

    bool Discord.Models.IMessageModel.IsTTS => (Message as Discord.Models.IMessageModel).IsTTS;

    bool Discord.Models.IMessageModel.MentionsEveryone => (Message as Discord.Models.IMessageModel).MentionsEveryone;

    ulong[] Discord.Models.IMessageModel.MentionedUsers => (Message as Discord.Models.IMessageModel).MentionedUsers;

    ulong[] Discord.Models.IMessageModel.MentionedRoles => (Message as Discord.Models.IMessageModel).MentionedRoles;

    System.Collections.Generic.IEnumerable<Discord.Models.IMentionedChannelModel> Discord.Models.IMessageModel.MentionedChannels => (Message as Discord.Models.IMessageModel).MentionedChannels;

    System.Collections.Generic.IEnumerable<Discord.Models.IAttachmentModel> Discord.Models.IMessageModel.Attachments => (Message as Discord.Models.IMessageModel).Attachments;

    System.Collections.Generic.IEnumerable<Discord.Models.IEmbedModel> Discord.Models.IMessageModel.Embeds => (Message as Discord.Models.IMessageModel).Embeds;

    System.Collections.Generic.IEnumerable<Discord.DiscordEmojiId> Discord.Models.IMessageModel.Reactions => (Message as Discord.Models.IMessageModel).Reactions;

    bool Discord.Models.IMessageModel.IsPinned => (Message as Discord.Models.IMessageModel).IsPinned;

    bool Discord.Models.IMessageModel.IsWebhook => (Message as Discord.Models.IMessageModel).IsWebhook;

    int Discord.Models.IMessageModel.Type => (Message as Discord.Models.IMessageModel).Type;

    Discord.Models.IMessageActivityModel? Discord.Models.IMessageModel.Activity => (Message as Discord.Models.IMessageModel).Activity;

    Discord.Models.IMessageApplicationModel? Discord.Models.IMessageModel.Application => (Message as Discord.Models.IMessageModel).Application;

    Discord.Models.IMessageReferenceModel? Discord.Models.IMessageModel.MessageReference => (Message as Discord.Models.IMessageModel).MessageReference;

    int Discord.Models.IMessageModel.Flags => (Message as Discord.Models.IMessageModel).Flags;

    Discord.Models.IMessageInteractionMetadataModel? Discord.Models.IMessageModel.InteractionMetadata => (Message as Discord.Models.IMessageModel).InteractionMetadata;

    ulong? Discord.Models.IMessageModel.ThreadId => (Message as Discord.Models.IMessageModel).ThreadId;

    ulong? Discord.Models.IMessageModel.ThreadGuildId => (Message as Discord.Models.IMessageModel).ThreadGuildId;

    System.Collections.Generic.IEnumerable<Discord.Models.Json.MessageComponent> Discord.Models.IMessageModel.Components => (Message as Discord.Models.IMessageModel).Components;

    System.Collections.Generic.IEnumerable<Discord.Models.IStickerItemModel> Discord.Models.IMessageModel.Stickers => (Message as Discord.Models.IMessageModel).Stickers;

    int? Discord.Models.IMessageModel.Position => (Message as Discord.Models.IMessageModel).Position;

    Discord.Models.IMessageRoleSubscriptionData? Discord.Models.IMessageModel.RoleSubscriptionData => (Message as Discord.Models.IMessageModel).RoleSubscriptionData;

    Discord.Models.IPollModel? Discord.Models.IMessageModel.Poll => (Message as Discord.Models.IMessageModel).Poll;

    ulong Discord.Models.IEntityModel<ulong>.Id => (Message as Discord.Models.IEntityModel<ulong>).Id;
}