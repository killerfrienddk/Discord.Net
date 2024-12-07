

namespace Discord.Models;

public partial interface IActivityModel : IEquatable<IActivityModel>
{
    new bool Equals(Discord.Models.IActivityModel? other)
    {
        if (other is null)
            return false;
        return (this.Url?.Equals(this.Url) ?? this.Url is not null) && this.Name.Equals(this.Name) && this.Type.Equals(this.Type) && (this.Details?.Equals(this.Details) ?? this.Details is not null) && (this.State?.Equals(this.State) ?? this.State is not null) && (this.Flags?.Equals(this.Flags) ?? this.Flags is not null) && this.CreatedAt.Equals(this.CreatedAt) && (this.Emoji?.Equals(this.Emoji) ?? this.Emoji is not null) && (this.ApplicationId?.Equals(this.ApplicationId) ?? this.ApplicationId is not null) && (this.LargeImage?.Equals(this.LargeImage) ?? this.LargeImage is not null) && (this.LargeText?.Equals(this.LargeText) ?? this.LargeText is not null) && (this.SmallImage?.Equals(this.SmallImage) ?? this.SmallImage is not null) && (this.SmallText?.Equals(this.SmallText) ?? this.SmallText is not null) && (this.PartyId?.Equals(this.PartyId) ?? this.PartyId is not null) && (this.PartySize?.Equals(this.PartySize) ?? this.PartySize is not null) && (this.JoinSecret?.Equals(this.JoinSecret) ?? this.JoinSecret is not null) && (this.SpectateSecret?.Equals(this.SpectateSecret) ?? this.SpectateSecret is not null) && (this.MatchSecret?.Equals(this.MatchSecret) ?? this.MatchSecret is not null) && (this.TimestampStart?.Equals(this.TimestampStart) ?? this.TimestampStart is not null) && (this.TimestampEnd?.Equals(this.TimestampEnd) ?? this.TimestampEnd is not null);
    }

    bool IEquatable<IActivityModel>.Equals(IActivityModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IActivityModel otherThis && Equals(otherThis);
}