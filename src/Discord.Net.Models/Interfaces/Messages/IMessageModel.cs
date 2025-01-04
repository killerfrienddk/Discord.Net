using Discord.Models.Json;

namespace Discord.Models;

[ModelEquality, HasPartialVariant]
public partial interface IMessageModel : IEntityModel<ulong>
{
    ulong ChannelId { get; }
    ModelOrId<IUserModel, ulong> Author { get; }
    string Content { get; }
    
    DateTimeOffset Timestamp { get; }
    DateTimeOffset? EditedTimestamp { get; }
    
    bool IsTTS { get; }
    bool MentionsEveryone { get; }
    
    IReadOnlyCollection<ModelOrId<IUserModel, ulong>> Mentions { get; }
    IReadOnlyCollection<ulong> MentionedRoles { get; }
    IReadOnlyCollection<IMentionedChannelModel> MentionedChannels { get; }
    
    IReadOnlyCollection<IAttachmentModel> Attachments { get; }
    IReadOnlyCollection<IEmbedModel> Embeds { get; }
    IReadOnlyCollection<IReactionModel> Reactions { get; }
    
    Optional<string> Nonce { get; }
    
    bool IsPinned { get; }
    
    Optional<ulong> WebhookId { get; }
    
    int Type { get; }
    
    Optional<IMessageActivityModel> Activity { get; }
    Optional<IPartialApplicationModel> Application { get; }
    
    Optional<ulong> ApplicationId { get; }
    
    Optional<int> Flags { get; }
    
    Optional<IMessageReferenceModel> MessageReference { get; }
    Optional<IReadOnlyCollection<IMessageSnapshotModel>> MessageSnapshots { get; }
    Optional<ModelOrId<IMessageModel, ulong>?> ReferencedMessage { get; }
    
    Optional<IMessageInteractionMetadataModel> InteractionMetadata { get; }
    
    Optional<ModelOrId<IThreadChannelModel, ulong>> Thread { get; }
    
    Optional<IReadOnlyCollection<IMessageComponentModel>> Components { get; }
    
    Optional<IReadOnlyCollection<IStickerItemModel>> StickerItems { get; }
    
    Optional<int> Position { get; }
    
    Optional<IMessageRoleSubscriptionData> RoleSubscriptionData { get; }
    
    Optional<IResolvedDataModel> Resolved { get; }
    
    Optional<IPollModel> Poll { get; }
    
    Optional<IMessageCallModel> Call { get; }
    
}