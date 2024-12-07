

namespace Discord.Models;

public partial interface ISubCommandGroupApplicationCommandOptionModel : IEquatable<ISubCommandGroupApplicationCommandOptionModel>
{
    new bool Equals(Discord.Models.ISubCommandGroupApplicationCommandOptionModel? other)
    {
        if (other is null)
            return false;
        return (this.Options?.Equals(this.Options) ?? this.Options is not null) && this.Type.Equals(this.Type) && this.Name.Equals(this.Name) && (this.NameLocalizations?.Equals(this.NameLocalizations) ?? this.NameLocalizations is not null) && this.Description.Equals(this.Description) && (this.DescriptionLocalizations?.Equals(this.DescriptionLocalizations) ?? this.DescriptionLocalizations is not null);
    }

    bool IEquatable<ISubCommandGroupApplicationCommandOptionModel>.Equals(ISubCommandGroupApplicationCommandOptionModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is ISubCommandGroupApplicationCommandOptionModel otherThis && Equals(otherThis);
    bool IApplicationCommandOptionModel.Equals(IApplicationCommandOptionModel? other) => other is ISubCommandGroupApplicationCommandOptionModel otherThis && Equals(otherThis);
}