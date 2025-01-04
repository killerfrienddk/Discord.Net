using System.Text.Json.Serialization;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IPartialMessageModel : 
    IPartialModel,
    IEntityModel<ulong>
{
    Discord.Optional<ulong> ChannelId { get; }

    Discord.Optional<Discord.Models.ModelOrId<Discord.Models.IUserModel, ulong>> Author { get; }

    Discord.Optional<string> Content { get; }

    Discord.Optional<System.DateTimeOffset> Timestamp { get; }

    Discord.Optional<System.DateTimeOffset?> EditedTimestamp { get; }

    Discord.Optional<bool> IsTTS { get; }

    Discord.Optional<bool> MentionsEveryone { get; }

    Discord.Optional<System.Collections.Generic.IReadOnlyCollection<Discord.Models.ModelOrId<Discord.Models.IUserModel, ulong>>> Mentions { get; }

    Discord.Optional<System.Collections.Generic.IReadOnlyCollection<ulong>> MentionedRoles { get; }

    Discord.Optional<System.Collections.Generic.IReadOnlyCollection<Discord.Models.IMentionedChannelModel>> MentionedChannels { get; }

    Discord.Optional<System.Collections.Generic.IReadOnlyCollection<Discord.Models.IAttachmentModel>> Attachments { get; }

    Discord.Optional<System.Collections.Generic.IReadOnlyCollection<Discord.Models.IEmbedModel>> Embeds { get; }

    Discord.Optional<System.Collections.Generic.IReadOnlyCollection<Discord.Models.IReactionModel>> Reactions { get; }

    Discord.Optional<string> Nonce { get; }

    Discord.Optional<bool> IsPinned { get; }

    Discord.Optional<ulong> WebhookId { get; }

    Discord.Optional<int> Type { get; }

    Discord.Optional<Discord.Models.IMessageActivityModel> Activity { get; }

    Discord.Optional<IPartialApplicationModel> Application { get; }

    Discord.Optional<ulong> ApplicationId { get; }

    Discord.Optional<int> Flags { get; }

    Discord.Optional<Discord.Models.IMessageReferenceModel> MessageReference { get; }

    Discord.Optional<System.Collections.Generic.IReadOnlyCollection<Discord.Models.IMessageSnapshotModel>> MessageSnapshots { get; }

    Discord.Optional<Discord.Models.ModelOrId<Discord.Models.IMessageModel, ulong>?> ReferencedMessage { get; }

    Discord.Optional<Discord.Models.IMessageInteractionMetadataModel> InteractionMetadata { get; }

    Discord.Optional<Discord.Models.ModelOrId<Discord.Models.IThreadChannelModel, ulong>> Thread { get; }

    Discord.Optional<System.Collections.Generic.IReadOnlyCollection<Discord.Models.IMessageComponentModel>> Components { get; }

    Discord.Optional<System.Collections.Generic.IReadOnlyCollection<Discord.Models.IStickerItemModel>> StickerItems { get; }

    Discord.Optional<int> Position { get; }

    Discord.Optional<Discord.Models.IMessageRoleSubscriptionData> RoleSubscriptionData { get; }

    Discord.Optional<Discord.Models.IResolvedDataModel> Resolved { get; }

    Discord.Optional<Discord.Models.IPollModel> Poll { get; }

    Discord.Optional<Discord.Models.IMessageCallModel> Call { get; }

    Type IPartialModel.UnderlyingModelType => typeof(Discord.Models.IMessageModel);
}
