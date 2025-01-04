namespace Discord.Models;

public interface IApplicationRoleConnectionModel
{
    string? PlatformName { get; }
    string? PlatformUsername { get; }
    IReadOnlyDictionary<string, string> Metadata { get; }
}
