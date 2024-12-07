

namespace Discord.Models;

public partial interface IStringApplicationCommandOptionModel : IEquatable<IStringApplicationCommandOptionModel>
{
    new bool Equals(Discord.Models.IStringApplicationCommandOptionModel? other)
    {
        if (other is null)
            return false;
        return (this.IsRequired?.Equals(this.IsRequired) ?? this.IsRequired is not null) && (this.Choices?.Equals(this.Choices) ?? this.Choices is not null) && (this.MinLength?.Equals(this.MinLength) ?? this.MinLength is not null) && (this.MaxLength?.Equals(this.MaxLength) ?? this.MaxLength is not null) && (this.Autocomplete?.Equals(this.Autocomplete) ?? this.Autocomplete is not null) && this.Type.Equals(this.Type) && this.Name.Equals(this.Name) && (this.NameLocalizations?.Equals(this.NameLocalizations) ?? this.NameLocalizations is not null) && this.Description.Equals(this.Description) && (this.DescriptionLocalizations?.Equals(this.DescriptionLocalizations) ?? this.DescriptionLocalizations is not null);
    }

    bool IEquatable<IStringApplicationCommandOptionModel>.Equals(IStringApplicationCommandOptionModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IStringApplicationCommandOptionModel otherThis && Equals(otherThis);
    bool IApplicationCommandOptionModel.Equals(IApplicationCommandOptionModel? other) => other is IStringApplicationCommandOptionModel otherThis && Equals(otherThis);
}