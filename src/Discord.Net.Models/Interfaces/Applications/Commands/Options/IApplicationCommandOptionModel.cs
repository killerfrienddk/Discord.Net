namespace Discord.Models;

[ModelEquality]
public partial interface IApplicationCommandOptionModel : IModel
{
    int Type { get; }
    string Name { get; }
    Optional<IReadOnlyDictionary<string, string>?> NameLocalizations { get; }
    string Description { get; }
    Optional<IReadOnlyDictionary<string, string>?> DescriptionLocalizations { get; }
}