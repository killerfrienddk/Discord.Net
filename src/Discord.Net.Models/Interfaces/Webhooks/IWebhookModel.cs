namespace Discord.Models;

[ModelEquality]
public partial interface IWebhookModel : IEntityModel<ulong>
{
    int Type { get; }
    Optional<ModelOrId<IUserModel, ulong>> User { get; }
    string? Name { get; }
    string? Avatar { get; }
    ulong? ApplicationId { get; }
}
