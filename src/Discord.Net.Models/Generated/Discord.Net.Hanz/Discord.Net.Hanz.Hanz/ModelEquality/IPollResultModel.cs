

namespace Discord.Models;

public partial interface IPollResultModel : IEquatable<IPollResultModel>
{
    new bool Equals(Discord.Models.IPollResultModel? other)
    {
        if (other is null)
            return false;
        return this.IsFinalized.Equals(this.IsFinalized) && this.AnswerCounts.Equals(this.AnswerCounts);
    }

    bool IEquatable<IPollResultModel>.Equals(IPollResultModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IPollResultModel otherThis && Equals(otherThis);
}