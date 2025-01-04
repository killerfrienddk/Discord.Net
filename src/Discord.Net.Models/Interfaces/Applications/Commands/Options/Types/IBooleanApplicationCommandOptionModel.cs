namespace Discord.Models;

[ModelEquality]
public partial interface IBooleanApplicationCommandOptionModel : IApplicationCommandOptionModel
{
    Optional<bool> IsRequired { get; }
}