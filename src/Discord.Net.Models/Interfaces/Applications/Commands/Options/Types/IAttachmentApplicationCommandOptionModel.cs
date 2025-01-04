namespace Discord.Models;

[ModelEquality]
public partial interface IAttachmentApplicationCommandOptionModel : IApplicationCommandOptionModel
{
    Optional<bool> IsRequired { get; }
}