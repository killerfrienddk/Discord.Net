using Discord.Models.Json;

namespace Discord.Models;

public partial interface IMessageInteractionMetadataModel : IEquatable<IMessageInteractionMetadataModel>
{
    new bool Equals(Discord.Models.IMessageInteractionMetadataModel? other)
    {
        if (other is null)
            return false;
        return this.Type.Equals(this.Type) && this.UserId.Equals(this.UserId) && this.AuthorizingIntegrationOwners.Equals(this.AuthorizingIntegrationOwners) && (this.OriginalResponseMessageId?.Equals(this.OriginalResponseMessageId) ?? this.OriginalResponseMessageId is not null) && (this.InteractedMessageId?.Equals(this.InteractedMessageId) ?? this.InteractedMessageId is not null) && (this.TriggeringInteractionMetadata?.Equals(this.TriggeringInteractionMetadata) ?? this.TriggeringInteractionMetadata is not null);
    }

    bool IEquatable<IMessageInteractionMetadataModel>.Equals(IMessageInteractionMetadataModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IMessageInteractionMetadataModel otherThis && Equals(otherThis);
}