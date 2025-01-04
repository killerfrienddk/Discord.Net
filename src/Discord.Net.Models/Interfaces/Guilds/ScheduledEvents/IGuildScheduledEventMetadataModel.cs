namespace Discord.Models;

[ModelEquality]
public partial interface IGuildScheduledEventMetadataModel : IModel
{
    Optional<string> Location { get; }
}