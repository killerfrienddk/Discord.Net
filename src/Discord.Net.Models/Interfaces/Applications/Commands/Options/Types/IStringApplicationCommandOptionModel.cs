namespace Discord.Models;

[ModelEquality]
public partial interface IStringApplicationCommandOptionModel : IApplicationCommandOptionModel
{
    Optional<bool> IsRequired { get; }
    Optional<IReadOnlyCollection<IApplicationCommandOptionChoiceModel<string>>> Choices { get; }
    Optional<int> MinLength { get; }
    Optional<int> MaxLength { get; }
    Optional<bool> Autocomplete { get; }
}