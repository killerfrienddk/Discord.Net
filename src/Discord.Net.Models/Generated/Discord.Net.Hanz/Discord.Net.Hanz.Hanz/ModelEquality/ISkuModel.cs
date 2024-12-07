

namespace Discord.Models;

public partial interface ISkuModel : IEquatable<ISkuModel>
{
    new bool Equals(Discord.Models.ISkuModel? other)
    {
        if (other is null)
            return false;
        return this.Type.Equals(this.Type) && this.ApplicationId.Equals(this.ApplicationId) && this.Name.Equals(this.Name) && this.Slug.Equals(this.Slug) && this.Flags.Equals(this.Flags);
    }

    bool IEquatable<ISkuModel>.Equals(ISkuModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is ISkuModel otherThis && Equals(otherThis);
}