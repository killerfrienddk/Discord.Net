

namespace Discord.Models;

public partial interface IEmojiModel : IEquatable<IEmojiModel>
{
    new bool Equals(Discord.Models.IEmojiModel? other)
    {
        if (other is null)
            return false;
        return this.Name.Equals(this.Name);
    }

    bool IEquatable<IEmojiModel>.Equals(IEmojiModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IEmojiModel otherThis && Equals(otherThis);
    bool IEmoteModel.Equals(IEmoteModel? other) => other is IEmojiModel otherThis && Equals(otherThis);
};