

namespace Discord.Models;

public partial interface IInteractionCallbackModel : IEquatable<IInteractionCallbackModel>
{
    new bool Equals(Discord.Models.IInteractionCallbackModel? other)
    {
        if (other is null)
            return false;
        return this.Type.Equals(this.Type) && (this.ActivityInstanceId?.Equals(this.ActivityInstanceId) ?? this.ActivityInstanceId is not null) && (this.ResponseMessageId?.Equals(this.ResponseMessageId) ?? this.ResponseMessageId is not null) && (this.ResponseMessageLoading?.Equals(this.ResponseMessageLoading) ?? this.ResponseMessageLoading is not null) && (this.ResponseMessageEphemeral?.Equals(this.ResponseMessageEphemeral) ?? this.ResponseMessageEphemeral is not null);
    }

    bool IEquatable<IInteractionCallbackModel>.Equals(IInteractionCallbackModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IInteractionCallbackModel otherThis && Equals(otherThis);
}