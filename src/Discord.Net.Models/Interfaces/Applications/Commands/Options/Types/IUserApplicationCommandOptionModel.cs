namespace Discord.Models;

[ModelEquality]
public partial interface IUserApplicationCommandOptionModel : IApplicationCommandOptionModel
{
    Optional<bool> IsRequired { get; }
}