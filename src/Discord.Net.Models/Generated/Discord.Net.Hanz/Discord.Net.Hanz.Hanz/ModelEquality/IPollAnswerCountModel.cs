

namespace Discord.Models;

public partial interface IPollAnswerCountModel : IEquatable<IPollAnswerCountModel>
{
    new bool Equals(Discord.Models.IPollAnswerCountModel? other)
    {
        if (other is null)
            return false;
        return this.Id.Equals(this.Id) && this.Count.Equals(this.Count) && this.MeVoted.Equals(this.MeVoted);
    }

    bool IEquatable<IPollAnswerCountModel>.Equals(IPollAnswerCountModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IPollAnswerCountModel otherThis && Equals(otherThis);
}