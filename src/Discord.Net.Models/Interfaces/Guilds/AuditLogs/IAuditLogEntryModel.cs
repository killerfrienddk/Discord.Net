namespace Discord.Models;

public interface IAuditLogEntryModel : IEntityModel<ulong>
{
    string? TargetId { get; }
    IReadOnlyCollection<IAuditLogChangeModel>? Changes { get; }
    ulong? UserId { get; }
    int ActionType { get; }
    Optional<IAuditLogOptionsModel> Options { get; }
    Optional<string> Reason { get; }
}
