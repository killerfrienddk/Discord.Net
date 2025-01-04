namespace Discord.Models;

[ModelEquality]
public partial interface IUserConnectionModel : IEntityModel<string>
{
    string Name { get; }
    string Type { get; }
    Optional<bool> IsRevoked { get; }
    Optional<IReadOnlyCollection<IPartialIntegrationModel>> Integrations { get; }
    bool IsVerified { get; }
    bool FriendSyncEnabled { get; }
    bool ShowActivity { get; }
    bool IsTwoWayLink { get; }
    int Visibility { get; }
}
