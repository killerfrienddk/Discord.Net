namespace Discord.Models;

public interface IModel : IEquatable<IModel>
{
    bool IEquatable<IModel>.Equals(IModel? other) => Equals(this, other);
}