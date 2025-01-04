namespace Discord.Models;

public interface IApplicationRoleConnectionMetadataModel : 
    IEntityModel<string>
{
    int Type { get; }
    string Key { get; }
    string Name { get; }
    Optional<IReadOnlyDictionary<string, string>> NameLocalizations { get; }
    string Description { get; }
    Optional<IReadOnlyDictionary<string, string>> DescriptionLocalization { get; }

    string IEntityModel<string>.Id => Key;
}