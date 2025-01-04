namespace Discord.Models;

[ModelEquality]
public partial interface IMentionableApplicationCommandOptionModel : IApplicationCommandOptionModel
{
    Optional<bool> IsRequired { get; }
}