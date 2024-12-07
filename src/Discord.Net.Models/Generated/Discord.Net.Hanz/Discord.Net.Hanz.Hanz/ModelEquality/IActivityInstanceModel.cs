

namespace Discord.Models;

public partial interface IActivityInstanceModel : IEquatable<IActivityInstanceModel>
{
    new bool Equals(Discord.Models.IActivityInstanceModel? other)
    {
        if (other is null)
            return false;
        return this.Id.Equals(this.Id);
    }

    bool IEquatable<IActivityInstanceModel>.Equals(IActivityInstanceModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IActivityInstanceModel otherThis && Equals(otherThis);
}