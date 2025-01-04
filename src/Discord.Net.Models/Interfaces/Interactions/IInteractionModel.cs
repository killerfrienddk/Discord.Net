namespace Discord.Models;

[ModelEquality]
public partial interface IInteractionModel : IEntityModel<ulong>
{
    ulong ApplicationId { get; }
    int Type { get; }
    Optional<IInteractionDataModel> Data { get; }
    Optional<ModelOrId<IPartialGuildModel, ulong>> Guild { get; }
    Optional<ModelOrId<IPartialChannelModel, ulong>> Channel { get; }
    Optional<ModelOrId<IUserModel, ulong>> User { get; }
    Optional<ModelOrId<IMemberModel, ulong>> Member { get; }
    string Token { get; }
    int Version { get; }
    Optional<ModelOrId<IMessageModel, ulong>> Message { get; }
    string AppPermissions { get; }
    Optional<string> Locale { get; }
    Optional<string> GuildLocale { get; }
    IReadOnlyCollection<IEntitlementModel> Entitlements { get; }
    IApplicationIntegrationTypes AuthorizingIntegrationOwners { get; }
    Optional<int> Context { get; }
}
