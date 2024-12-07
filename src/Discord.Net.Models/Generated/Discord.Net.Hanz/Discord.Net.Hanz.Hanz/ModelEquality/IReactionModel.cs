

namespace Discord.Models;

public partial interface IReactionModel : IEquatable<IReactionModel>
{
    new bool Equals(Discord.Models.IReactionModel? other)
    {
        if (other is null)
            return false;
        return this.Total.Equals(this.Total) && this.BurstCount.Equals(this.BurstCount) && this.NormalCount.Equals(this.NormalCount) && this.Me.Equals(this.Me) && this.MeBurst.Equals(this.MeBurst) && this.BurstColors.Equals(this.BurstColors);
    }

    bool IEquatable<IReactionModel>.Equals(IReactionModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IReactionModel otherThis && Equals(otherThis);
}