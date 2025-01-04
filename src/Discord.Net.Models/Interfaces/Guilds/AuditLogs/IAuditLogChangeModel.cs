namespace Discord.Models;

public interface IAuditLogChangeModel
{
    Optional<object?> OldValue { get; }
    Optional<object?> NewValue { get; }
    
    string Key { get; }
}
