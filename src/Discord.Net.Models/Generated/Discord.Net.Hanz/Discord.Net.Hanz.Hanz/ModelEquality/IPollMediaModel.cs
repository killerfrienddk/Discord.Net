

namespace Discord.Models;

public partial interface IPollMediaModel : IEquatable<IPollMediaModel>
{
    new bool Equals(Discord.Models.IPollMediaModel? other)
    {
        if (other is null)
            return false;
        return (this.Text?.Equals(this.Text) ?? this.Text is not null) && (this.Emoji?.Equals(this.Emoji) ?? this.Emoji is not null);
    }

    bool IEquatable<IPollMediaModel>.Equals(IPollMediaModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IPollMediaModel otherThis && Equals(otherThis);
}