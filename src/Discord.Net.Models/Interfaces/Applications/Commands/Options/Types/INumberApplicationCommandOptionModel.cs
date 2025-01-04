namespace Discord.Models;

[ModelEquality]
public partial interface INumberApplicationCommandOptionModel : IApplicationCommandOptionModel
{
    Optional<bool> IsRequired { get; }
    Optional<IReadOnlyCollection<IApplicationCommandOptionChoiceModel<double>>> Choices { get; }
    Optional<double> MinValue { get; }
    Optional<double> MaxValue { get; }
    Optional<bool> Autocomplete { get; }
}