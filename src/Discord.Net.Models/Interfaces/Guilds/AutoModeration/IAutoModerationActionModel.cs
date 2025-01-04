namespace Discord.Models;

public interface IAutoModerationActionModel
{
    int Type { get; }
    Optional<IAutoModerationActionMetadataModel> Metadata { get; }
}
