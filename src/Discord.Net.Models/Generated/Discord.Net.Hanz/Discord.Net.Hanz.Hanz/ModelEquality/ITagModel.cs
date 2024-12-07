

namespace Discord.Models;

public partial interface ITagModel : IEquatable<ITagModel>
{
    new bool Equals(Discord.Models.ITagModel? other)
    {
        if (other is null)
            return false;
        return this.Name.Equals(this.Name) && this.Moderated.Equals(this.Moderated) && (this.Emoji?.Equals(this.Emoji) ?? this.Emoji is not null);
    }

    bool IEquatable<ITagModel>.Equals(ITagModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is ITagModel otherThis && Equals(otherThis);
}