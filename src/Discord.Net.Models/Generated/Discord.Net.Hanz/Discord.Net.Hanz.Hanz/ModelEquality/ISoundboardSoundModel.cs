

namespace Discord.Models;

public partial interface ISoundboardSoundModel : IEquatable<ISoundboardSoundModel>
{
    new bool Equals(Discord.Models.ISoundboardSoundModel? other)
    {
        if (other is null)
            return false;
        return this.Name.Equals(this.Name) && this.Volume.Equals(this.Volume) && (this.EmojiId?.Equals(this.EmojiId) ?? this.EmojiId is not null) && (this.EmojiName?.Equals(this.EmojiName) ?? this.EmojiName is not null) && this.IsAvailable.Equals(this.IsAvailable);
    }

    bool IEquatable<ISoundboardSoundModel>.Equals(ISoundboardSoundModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is ISoundboardSoundModel otherThis && Equals(otherThis);
}