

namespace Discord.Models;

public partial interface IGatewayMessage : IEquatable<IGatewayMessage>
{
    new bool Equals(Discord.Models.IGatewayMessage? other)
    {
        if (other is null)
            return false;
        return this.OpCode.Equals(this.OpCode) && (this.Payload?.Equals(this.Payload) ?? this.Payload is not null) && (this.Sequence?.Equals(this.Sequence) ?? this.Sequence is not null) && (this.EventName?.Equals(this.EventName) ?? this.EventName is not null);
    }

    bool IEquatable<IGatewayMessage>.Equals(IGatewayMessage? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IGatewayMessage otherThis && Equals(otherThis);
}