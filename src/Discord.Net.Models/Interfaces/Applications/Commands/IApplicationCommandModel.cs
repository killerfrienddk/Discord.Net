namespace Discord.Models;

[ModelEquality]
public partial interface IApplicationCommandModel : 
    IEntityModel<ulong>
{
    int? Type { get; }
    ulong ApplicationId { get; }
    Optional<ulong> GuildId { get; }
    string Name { get; }
    Optional<IReadOnlyDictionary<string, string>> NameLocalization { get; }
    string Description { get; }
    Optional<IReadOnlyDictionary<string, string>> DescriptionLocalization { get; }
    string? DefaultMemberPermissions { get; }
    Optional<bool> IsNsfw { get; }
    Optional<int[]> IntegrationTypes { get; }
    Optional<int[]> Contexts { get; }
    ulong Version { get; }
}