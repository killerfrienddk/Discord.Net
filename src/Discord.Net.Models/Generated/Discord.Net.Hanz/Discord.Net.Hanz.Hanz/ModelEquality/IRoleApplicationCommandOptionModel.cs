

namespace Discord.Models;

public partial interface IRoleApplicationCommandOptionModel : IEquatable<IRoleApplicationCommandOptionModel>
{
    new bool Equals(Discord.Models.IRoleApplicationCommandOptionModel? other)
    {
        if (other is null)
            return false;
        return (this.IsRequired?.Equals(this.IsRequired) ?? this.IsRequired is not null) && this.Type.Equals(this.Type) && this.Name.Equals(this.Name) && (this.NameLocalizations?.Equals(this.NameLocalizations) ?? this.NameLocalizations is not null) && this.Description.Equals(this.Description) && (this.DescriptionLocalizations?.Equals(this.DescriptionLocalizations) ?? this.DescriptionLocalizations is not null);
    }

    bool IEquatable<IRoleApplicationCommandOptionModel>.Equals(IRoleApplicationCommandOptionModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IRoleApplicationCommandOptionModel otherThis && Equals(otherThis);
    bool IApplicationCommandOptionModel.Equals(IApplicationCommandOptionModel? other) => other is IRoleApplicationCommandOptionModel otherThis && Equals(otherThis);
}