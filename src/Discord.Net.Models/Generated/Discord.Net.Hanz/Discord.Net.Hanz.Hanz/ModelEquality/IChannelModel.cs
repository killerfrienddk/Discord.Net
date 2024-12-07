

namespace Discord.Models;

public partial interface IChannelModel : IEquatable<IChannelModel>
{
    new bool Equals(Discord.Models.IChannelModel? other)
    {
        if (other is null)
            return false;
        return this.Type.Equals(this.Type);
    }

    bool IEquatable<IChannelModel>.Equals(IChannelModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IChannelModel otherThis && Equals(otherThis);
}