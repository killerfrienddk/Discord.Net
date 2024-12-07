

namespace Discord.Models;

public partial interface IApplicationCommandOptionModel : IEquatable<IApplicationCommandOptionModel>
{
    new bool Equals(Discord.Models.IApplicationCommandOptionModel? other)
    {
        if (other is null)
            return false;
        return this.Type.Equals(this.Type) && this.Name.Equals(this.Name) && (this.NameLocalizations?.Equals(this.NameLocalizations) ?? this.NameLocalizations is not null) && this.Description.Equals(this.Description) && (this.DescriptionLocalizations?.Equals(this.DescriptionLocalizations) ?? this.DescriptionLocalizations is not null);
    }

    bool IEquatable<IApplicationCommandOptionModel>.Equals(IApplicationCommandOptionModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IApplicationCommandOptionModel otherThis && Equals(otherThis);
}