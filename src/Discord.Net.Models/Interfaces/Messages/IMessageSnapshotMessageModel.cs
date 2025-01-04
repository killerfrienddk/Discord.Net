namespace Discord.Models;

[ModelEquality]
public partial interface IMessageSnapshotMessageModel : IModel
{
    int Type { get; }
    string Content { get; }
    IReadOnlyCollection<IEmbedModel> Embeds { get; }
    IReadOnlyCollection<IAttachmentModel> Attachments { get; }
    DateTimeOffset Timestamp { get; }
    DateTimeOffset? EditedTimestamp { get; }
    Optional<int> Flags { get; }
    IReadOnlyCollection<ModelOrId<IUserModel, ulong>> Mentions { get; }
    IReadOnlyCollection<ulong> MentionedRoles { get; }
    IReadOnlyCollection<ModelOrId<IStickerItemModel, ulong>> StickerItems { get; }
    IReadOnlyCollection<IMessageComponentModel> Components { get; }
}