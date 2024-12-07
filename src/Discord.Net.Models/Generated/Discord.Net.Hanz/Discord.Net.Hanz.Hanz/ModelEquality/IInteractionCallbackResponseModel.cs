

namespace Discord.Models;

public partial interface IInteractionCallbackResponseModel : IEquatable<IInteractionCallbackResponseModel>
{
    new bool Equals(Discord.Models.IInteractionCallbackResponseModel? other)
    {
        if (other is null)
            return false;
        return this.Interaction.Equals(this.Interaction) && (this.Resource?.Equals(this.Resource) ?? this.Resource is not null);
    }

    bool IEquatable<IInteractionCallbackResponseModel>.Equals(IInteractionCallbackResponseModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IInteractionCallbackResponseModel otherThis && Equals(otherThis);
}