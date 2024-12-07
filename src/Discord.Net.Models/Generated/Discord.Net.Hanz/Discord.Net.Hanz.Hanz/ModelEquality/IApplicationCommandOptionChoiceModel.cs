

namespace Discord.Models;

public partial interface IApplicationCommandOptionChoiceModel : IEquatable<IApplicationCommandOptionChoiceModel>
{
    new bool Equals(Discord.Models.IApplicationCommandOptionChoiceModel? other)
    {
        if (other is null)
            return false;
        return this.Name.Equals(this.Name) && (this.NameLocalization?.Equals(this.NameLocalization) ?? this.NameLocalization is not null) && this.Value.Equals(this.Value);
    }

    bool IEquatable<IApplicationCommandOptionChoiceModel>.Equals(IApplicationCommandOptionChoiceModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IApplicationCommandOptionChoiceModel otherThis && Equals(otherThis);
}