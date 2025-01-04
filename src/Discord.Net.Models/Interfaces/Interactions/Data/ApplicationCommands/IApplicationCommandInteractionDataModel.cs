namespace Discord.Models;

public interface IApplicationCommandInteractionDataModel : IInteractionDataModel
{
    ulong Id { get; }
    string Name { get; }
    int Type { get; }
    Optional<IResolvedDataModel> Resolved { get; }
    Optional<IReadOnlyCollection<IApplicationCommandInteractionOptionModel>> Options { get; }
    Optional<ulong> GuildId { get; }
    Optional<ulong> TargetId { get; }
}
