

namespace Discord.Models;

public partial interface IMentionedChannelModel : IEquatable<IMentionedChannelModel>
{
    new bool Equals(Discord.Models.IMentionedChannelModel? other)
    {
        if (other is null)
            return false;
        return this.Id.Equals(this.Id) && this.GuildId.Equals(this.GuildId) && this.Type.Equals(this.Type) && this.Name.Equals(this.Name);
    }

    bool IEquatable<IMentionedChannelModel>.Equals(IMentionedChannelModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IMentionedChannelModel otherThis && Equals(otherThis);
}