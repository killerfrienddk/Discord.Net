

namespace Discord.Models;

public partial interface ISubCommandApplicationCommandOptionModel : IEquatable<ISubCommandApplicationCommandOptionModel>
{
    new bool Equals(Discord.Models.ISubCommandApplicationCommandOptionModel? other)
    {
        if (other is null)
            return false;
        return (this.Options?.Equals(this.Options) ?? this.Options is not null) && this.Type.Equals(this.Type) && this.Name.Equals(this.Name) && (this.NameLocalizations?.Equals(this.NameLocalizations) ?? this.NameLocalizations is not null) && this.Description.Equals(this.Description) && (this.DescriptionLocalizations?.Equals(this.DescriptionLocalizations) ?? this.DescriptionLocalizations is not null);
    }

    bool IEquatable<ISubCommandApplicationCommandOptionModel>.Equals(ISubCommandApplicationCommandOptionModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is ISubCommandApplicationCommandOptionModel otherThis && Equals(otherThis);
    bool IApplicationCommandOptionModel.Equals(IApplicationCommandOptionModel? other) => other is ISubCommandApplicationCommandOptionModel otherThis && Equals(otherThis);
}