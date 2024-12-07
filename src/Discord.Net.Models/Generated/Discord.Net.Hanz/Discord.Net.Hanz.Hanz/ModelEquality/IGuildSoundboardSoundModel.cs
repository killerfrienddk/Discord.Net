

namespace Discord.Models;

public partial interface IGuildSoundboardSoundModel : IEquatable<IGuildSoundboardSoundModel>
{
    new bool Equals(Discord.Models.IGuildSoundboardSoundModel? other)
    {
        if (other is null)
            return false;
        return this.GuildId.Equals(this.GuildId) && (this.UserId?.Equals(this.UserId) ?? this.UserId is not null) && this.Name.Equals(this.Name) && this.Volume.Equals(this.Volume) && (this.EmojiId?.Equals(this.EmojiId) ?? this.EmojiId is not null) && (this.EmojiName?.Equals(this.EmojiName) ?? this.EmojiName is not null) && this.IsAvailable.Equals(this.IsAvailable);
    }

    bool IEquatable<IGuildSoundboardSoundModel>.Equals(IGuildSoundboardSoundModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IGuildSoundboardSoundModel otherThis && Equals(otherThis);
    bool ISoundboardSoundModel.Equals(ISoundboardSoundModel? other) => other is IGuildSoundboardSoundModel otherThis && Equals(otherThis);
}