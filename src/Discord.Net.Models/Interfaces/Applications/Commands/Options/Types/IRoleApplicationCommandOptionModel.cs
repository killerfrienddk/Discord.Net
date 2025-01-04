namespace Discord.Models;

[ModelEquality]
public partial interface IRoleApplicationCommandOptionModel : IApplicationCommandOptionModel
{
    Optional<bool> IsRequired { get; }
}