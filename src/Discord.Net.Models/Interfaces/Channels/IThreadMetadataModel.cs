namespace Discord.Models;

[ModelEquality]
public partial interface IThreadMetadataModel : IModel
{
    bool IsArchived { get; }
    int AutoArchiveDuration { get; }
    DateTimeOffset ArchiveTimestamp { get; }
    bool IsLocked { get; }
    Optional<bool> IsInvitable { get; }
    Optional<DateTimeOffset> CreatedAt { get; }
}