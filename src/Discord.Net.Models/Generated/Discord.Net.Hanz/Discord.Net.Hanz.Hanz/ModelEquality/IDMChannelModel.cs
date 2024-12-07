

namespace Discord.Models;

public partial interface IDMChannelModel : IEquatable<IDMChannelModel>
{
    new bool Equals(Discord.Models.IDMChannelModel? other)
    {
        if (other is null)
            return false;
        return this.RecipientId.Equals(this.RecipientId) && this.Type.Equals(this.Type);
    }

    bool IEquatable<IDMChannelModel>.Equals(IDMChannelModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IDMChannelModel otherThis && Equals(otherThis);
    bool IChannelModel.Equals(IChannelModel? other) => other is IDMChannelModel otherThis && Equals(otherThis);
}