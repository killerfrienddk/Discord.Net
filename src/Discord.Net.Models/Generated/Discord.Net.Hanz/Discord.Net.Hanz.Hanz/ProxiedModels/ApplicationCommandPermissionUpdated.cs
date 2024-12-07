using System.Text.Json.Serialization;

namespace Discord.Models.Json;

public sealed partial class ApplicationCommandPermissionUpdated : IExtendedModel<Discord.Models.Json.GuildApplicationCommandPermission>
{
    Discord.Models.Json.GuildApplicationCommandPermission IExtendedModel<Discord.Models.Json.GuildApplicationCommandPermission>.ExtendedValue => GuildApplicationCommandPermission;

    ulong Discord.Models.IGuildApplicationCommandPermissionsModel.ApplicationId => (GuildApplicationCommandPermission as Discord.Models.IGuildApplicationCommandPermissionsModel).ApplicationId;

    ulong Discord.Models.IGuildApplicationCommandPermissionsModel.GuildId => (GuildApplicationCommandPermission as Discord.Models.IGuildApplicationCommandPermissionsModel).GuildId;

    System.Collections.Generic.IEnumerable<Discord.Models.IApplicationCommandPermission> Discord.Models.IGuildApplicationCommandPermissionsModel.Permissions => (GuildApplicationCommandPermission as Discord.Models.IGuildApplicationCommandPermissionsModel).Permissions;

    ulong Discord.Models.IEntityModel<ulong>.Id => (GuildApplicationCommandPermission as Discord.Models.IEntityModel<ulong>).Id;
}