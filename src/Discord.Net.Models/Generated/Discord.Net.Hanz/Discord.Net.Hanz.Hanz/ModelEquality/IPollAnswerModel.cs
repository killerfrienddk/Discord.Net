

namespace Discord.Models;

public partial interface IPollAnswerModel : IEquatable<IPollAnswerModel>
{
    new bool Equals(Discord.Models.IPollAnswerModel? other)
    {
        if (other is null)
            return false;
        return this.Media.Equals(this.Media);
    }

    bool IEquatable<IPollAnswerModel>.Equals(IPollAnswerModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IPollAnswerModel otherThis && Equals(otherThis);
}