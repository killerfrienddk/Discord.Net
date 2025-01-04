namespace Discord.Models;

[ModelEquality]
public partial interface IIntegrationApplicationModel : IEntityModel<ulong>
{
    string Name { get; }
    string? Icon { get; }
    string Description { get; }
    Optional<ModelOrId<IUserModel, ulong>> Bot { get; }
}