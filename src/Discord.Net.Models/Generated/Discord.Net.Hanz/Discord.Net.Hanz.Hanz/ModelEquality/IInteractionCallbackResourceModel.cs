

namespace Discord.Models;

public partial interface IInteractionCallbackResourceModel : IEquatable<IInteractionCallbackResourceModel>
{
    new bool Equals(Discord.Models.IInteractionCallbackResourceModel? other)
    {
        if (other is null)
            return false;
        return this.Type.Equals(this.Type) && (this.ActivityInstance?.Equals(this.ActivityInstance) ?? this.ActivityInstance is not null) && (this.Message?.Equals(this.Message) ?? this.Message is not null);
    }

    bool IEquatable<IInteractionCallbackResourceModel>.Equals(IInteractionCallbackResourceModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IInteractionCallbackResourceModel otherThis && Equals(otherThis);
}