namespace Discord.Models;

public partial interface IMessageInteractionMetadataModel : IEntityModel<ulong>
{
    int Type { get; }
    ModelOrId<IUserModel, ulong> User { get; }
    IReadOnlyDictionary<int, ulong> AuthorizingIntegrationOwners { get; }
    Optional<ulong> OriginalResponseMessageId { get; }
}