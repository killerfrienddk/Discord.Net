namespace Discord.Models;

public interface IBlockMessageMetadataModel : IAutoModerationActionMetadataModel
{
    Optional<string> CustomMessage { get; }
}
