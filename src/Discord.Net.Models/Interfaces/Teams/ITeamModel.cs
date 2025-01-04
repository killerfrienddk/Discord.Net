namespace Discord.Models;

[ModelEquality]
public partial interface ITeamModel : IEntityModel<ulong>
{
    string? Icon { get; }
    IReadOnlyCollection<ModelOrId<ITeamMemberModel, ulong>> Members { get; }
    string Name { get; }
    ulong OwnerId { get; }
}