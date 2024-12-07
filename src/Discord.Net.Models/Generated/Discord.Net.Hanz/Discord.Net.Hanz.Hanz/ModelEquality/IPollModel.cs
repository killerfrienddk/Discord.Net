

namespace Discord.Models;

public partial interface IPollModel : IEquatable<IPollModel>
{
    new bool Equals(Discord.Models.IPollModel? other)
    {
        if (other is null)
            return false;
        return this.Question.Equals(this.Question) && this.Answers.Equals(this.Answers) && (this.Expiry?.Equals(this.Expiry) ?? this.Expiry is not null) && this.AllowMultiselect.Equals(this.AllowMultiselect) && this.LayoutType.Equals(this.LayoutType) && (this.Results?.Equals(this.Results) ?? this.Results is not null);
    }

    bool IEquatable<IPollModel>.Equals(IPollModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IPollModel otherThis && Equals(otherThis);
}