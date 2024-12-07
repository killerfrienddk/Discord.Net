using System.Numerics;

namespace Discord.Models;

public partial interface IOverwriteModel : IEquatable<IOverwriteModel>
{
    new bool Equals(Discord.Models.IOverwriteModel? other)
    {
        if (other is null)
            return false;
        return this.TargetId.Equals(this.TargetId) && this.Type.Equals(this.Type) && this.Allow.Equals(this.Allow) && this.Deny.Equals(this.Deny);
    }

    bool IEquatable<IOverwriteModel>.Equals(IOverwriteModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IOverwriteModel otherThis && Equals(otherThis);
}