namespace Discord.Models;

[ModelEquality]
public partial interface IClientStatusModel : IModel
{
    Optional<string> Desktop { get; }
    Optional<string> Mobile { get; }
    Optional<string> Web { get; }
}
