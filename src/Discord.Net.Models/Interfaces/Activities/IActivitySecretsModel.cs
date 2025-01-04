namespace Discord.Models;

[ModelEquality]
public partial interface IActivitySecretsModel : IModel
{
    Optional<string> Join { get; }
    Optional<string> Spectate { get; }
    Optional<string> Match { get; }
}