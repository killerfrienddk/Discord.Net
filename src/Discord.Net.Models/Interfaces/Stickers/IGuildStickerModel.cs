namespace Discord.Models;

[ModelEquality]
public partial interface IGuildStickerModel : IStickerModel
{
    Optional<bool> Available { get; }
    ulong GuildId { get; }
    Optional<ModelOrId<IUserModel, ulong>> User { get; }
}
