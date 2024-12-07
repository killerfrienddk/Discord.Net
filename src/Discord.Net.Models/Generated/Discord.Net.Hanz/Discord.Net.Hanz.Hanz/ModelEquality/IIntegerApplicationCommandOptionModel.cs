

namespace Discord.Models;

public partial interface IIntegerApplicationCommandOptionModel : IEquatable<IIntegerApplicationCommandOptionModel>
{
    new bool Equals(Discord.Models.IIntegerApplicationCommandOptionModel? other)
    {
        if (other is null)
            return false;
        return (this.IsRequired?.Equals(this.IsRequired) ?? this.IsRequired is not null) && (this.Choices?.Equals(this.Choices) ?? this.Choices is not null) && (this.MinValue?.Equals(this.MinValue) ?? this.MinValue is not null) && (this.MaxValue?.Equals(this.MaxValue) ?? this.MaxValue is not null) && (this.Autocomplete?.Equals(this.Autocomplete) ?? this.Autocomplete is not null) && this.Type.Equals(this.Type) && this.Name.Equals(this.Name) && (this.NameLocalizations?.Equals(this.NameLocalizations) ?? this.NameLocalizations is not null) && this.Description.Equals(this.Description) && (this.DescriptionLocalizations?.Equals(this.DescriptionLocalizations) ?? this.DescriptionLocalizations is not null);
    }

    bool IEquatable<IIntegerApplicationCommandOptionModel>.Equals(IIntegerApplicationCommandOptionModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IIntegerApplicationCommandOptionModel otherThis && Equals(otherThis);
    bool IApplicationCommandOptionModel.Equals(IApplicationCommandOptionModel? other) => other is IIntegerApplicationCommandOptionModel otherThis && Equals(otherThis);
}