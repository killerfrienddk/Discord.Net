

namespace Discord.Models;

public partial interface IBanModel : IEquatable<IBanModel>
{
    new bool Equals(Discord.Models.IBanModel? other)
    {
        if (other is null)
            return false;
        return (this.Reason?.Equals(this.Reason) ?? this.Reason is not null) && this.UserId.Equals(this.UserId);
    }

    bool IEquatable<IBanModel>.Equals(IBanModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IBanModel otherThis && Equals(otherThis);
}