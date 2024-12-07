

namespace Discord.Models;

public partial interface ICustomEmoteModel : IEquatable<ICustomEmoteModel>
{
    new bool Equals(Discord.Models.ICustomEmoteModel? other)
    {
        if (other is null)
            return false;
        return this.Id.Equals(this.Id) && this.Roles.Equals(this.Roles) && this.RequireColons.Equals(this.RequireColons) && this.IsManaged.Equals(this.IsManaged) && this.IsAnimated.Equals(this.IsAnimated) && this.IsAvailable.Equals(this.IsAvailable) && (this.UserId?.Equals(this.UserId) ?? this.UserId is not null) && this.Name.Equals(this.Name);
    }

    bool IEquatable<ICustomEmoteModel>.Equals(ICustomEmoteModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is ICustomEmoteModel otherThis && Equals(otherThis);
    bool IEmoteModel.Equals(IEmoteModel? other) => other is ICustomEmoteModel otherThis && Equals(otherThis);
}