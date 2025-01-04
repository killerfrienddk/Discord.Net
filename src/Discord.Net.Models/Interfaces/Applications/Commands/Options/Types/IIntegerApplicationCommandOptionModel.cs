namespace Discord.Models;

[ModelEquality]
public partial interface IIntegerApplicationCommandOptionModel : IApplicationCommandOptionModel
{
    Optional<bool> IsRequired { get; }
    Optional<IReadOnlyCollection<IApplicationCommandOptionChoiceModel<long>>> Choices { get; }
    Optional<long> MinValue { get; }
    Optional<long> MaxValue { get; }
    Optional<bool> Autocomplete { get; }
}