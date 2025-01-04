namespace Discord.Models;

[ModelEquality]
public partial interface ISoundboardSoundModel : IEntityModel<ulong>
{
    string Name { get; }
    double Volume { get; }
    Optional<DiscordEmojiId> Emoji { get; }
    bool IsAvailable { get; }
}