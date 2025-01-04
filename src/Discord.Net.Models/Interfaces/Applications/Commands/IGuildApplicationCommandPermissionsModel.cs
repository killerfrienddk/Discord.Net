namespace Discord.Models;

[ModelEquality]
public partial interface IGuildApplicationCommandPermissionsModel : IEntityModel<ulong>
{
    ulong ApplicationId { get; }
    ulong GuildId { get; }
    IReadOnlyCollection<IApplicationCommandPermission> Permissions { get; }
}
