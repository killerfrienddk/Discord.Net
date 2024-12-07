

namespace Discord.Models;

public partial interface IGroupDMChannelModel : IEquatable<IGroupDMChannelModel>
{
    new bool Equals(Discord.Models.IGroupDMChannelModel? other)
    {
        if (other is null)
            return false;
        return this.Recipients.Equals(this.Recipients) && this.Type.Equals(this.Type);
    }

    bool IEquatable<IGroupDMChannelModel>.Equals(IGroupDMChannelModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IGroupDMChannelModel otherThis && Equals(otherThis);
    bool IChannelModel.Equals(IChannelModel? other) => other is IGroupDMChannelModel otherThis && Equals(otherThis);
}