namespace Discord.Models;

[ModelEquality, HasPartialVariant]
public partial interface IIntegrationModel : IEntityModel<ulong>
{
    string Name { get; }
    string Type { get; }
    bool IsEnabled { get; }
    Optional<bool> IsSyncing { get; }
    Optional<ulong> RoleId { get; }
    Optional<bool> EnableEmoticons { get; }
    Optional<int> ExpireBehavior { get; }
    Optional<int> ExpireGracePeriod { get; }
    Optional<ModelOrId<IUserModel, ulong>> User { get; }
    IIntegrationAccountModel Account { get; }
    Optional<DateTimeOffset> SyncedAt { get; }
    Optional<int> SubscriberCount { get; }
    Optional<bool> IsRevoked { get; }
    Optional<IIntegrationApplicationModel> Application { get; }
    string[]? Scopes { get; }
}