namespace Discord.Models;

public interface IApplicationCommandInteractionOptionModel
{
    string Name { get; }
    int Type { get; }
    Optional<object> Value { get; }
    Optional<IReadOnlyCollection<IApplicationCommandInteractionOptionModel>> Options { get; }
    Optional<bool> IsFocused { get; }
}
