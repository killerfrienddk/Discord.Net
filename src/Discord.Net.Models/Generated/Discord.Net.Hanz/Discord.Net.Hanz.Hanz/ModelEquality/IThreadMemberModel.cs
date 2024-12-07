

namespace Discord.Models;

public partial interface IThreadMemberModel : IEquatable<IThreadMemberModel>
{
    new bool Equals(Discord.Models.IThreadMemberModel? other)
    {
        if (other is null)
            return false;
        return (this.ThreadId?.Equals(this.ThreadId) ?? this.ThreadId is not null) && (this.UserId?.Equals(this.UserId) ?? this.UserId is not null) && this.JoinTimestamp.Equals(this.JoinTimestamp) && this.Flags.Equals(this.Flags);
    }

    bool IEquatable<IThreadMemberModel>.Equals(IThreadMemberModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IThreadMemberModel otherThis && Equals(otherThis);
}