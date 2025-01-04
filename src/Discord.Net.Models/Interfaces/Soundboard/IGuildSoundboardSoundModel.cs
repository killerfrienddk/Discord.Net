namespace Discord.Models;

[ModelEquality]
public partial interface IGuildSoundboardSoundModel : ISoundboardSoundModel
{
    ulong GuildId { get; }
    Optional<ModelOrId<IUserModel, ulong>> User { get; }
}