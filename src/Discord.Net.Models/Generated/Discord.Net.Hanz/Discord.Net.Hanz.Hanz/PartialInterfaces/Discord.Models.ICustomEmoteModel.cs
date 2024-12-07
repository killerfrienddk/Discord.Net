

namespace Discord.Models;

public partial interface IPartialCustomEmoteModel : Discord.Models.IPartial<Discord.Models.ICustomEmoteModel>, Discord.Models.IPartialEmoteModel, Discord.Models.IEntityModel<ulong>
{
    [PartialIgnore]
    new ulong Id { get; }

    ulong[]? Roles { get; }

    bool RolesIsSpecified { get; }

    bool? RequireColons { get; }

    bool RequireColonsIsSpecified { get; }

    bool? IsManaged { get; }

    bool IsManagedIsSpecified { get; }

    bool? IsAnimated { get; }

    bool IsAnimatedIsSpecified { get; }

    bool? IsAvailable { get; }

    bool IsAvailableIsSpecified { get; }

    ulong? UserId { get; }

    bool UserIdIsSpecified { get; }

    DiscordEmojiId IEntityModel<DiscordEmojiId>.Id => new(Name, Id, IsAnimated);

    ulong IEntityModel<ulong>.Id => Id;
}