

namespace Discord.Models;

public partial interface IIntegrationAccountModel : IEquatable<IIntegrationAccountModel>
{
    new bool Equals(Discord.Models.IIntegrationAccountModel? other)
    {
        if (other is null)
            return false;
        return this.Name.Equals(this.Name);
    }

    bool IEquatable<IIntegrationAccountModel>.Equals(IIntegrationAccountModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IIntegrationAccountModel otherThis && Equals(otherThis);
}