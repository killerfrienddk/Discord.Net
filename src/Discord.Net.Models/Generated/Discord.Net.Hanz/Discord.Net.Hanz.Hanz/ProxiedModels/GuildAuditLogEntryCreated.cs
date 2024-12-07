using System.Text.Json.Serialization;

namespace Discord.Models.Json;

public sealed partial class GuildAuditLogEntryCreated : IExtendedModel<Discord.Models.Json.AuditLogEntry>
{
    Discord.Models.Json.AuditLogEntry IExtendedModel<Discord.Models.Json.AuditLogEntry>.ExtendedValue => AuditLogEntry;

    string? Discord.Models.IAuditLogEntryModel.TargetId => (AuditLogEntry as Discord.Models.IAuditLogEntryModel).TargetId;

    System.Collections.Generic.IEnumerable<Discord.Models.IAuditLogChangeModel>? Discord.Models.IAuditLogEntryModel.Changes => (AuditLogEntry as Discord.Models.IAuditLogEntryModel).Changes;

    ulong? Discord.Models.IAuditLogEntryModel.UserId => (AuditLogEntry as Discord.Models.IAuditLogEntryModel).UserId;

    int Discord.Models.IAuditLogEntryModel.ActionType => (AuditLogEntry as Discord.Models.IAuditLogEntryModel).ActionType;

    Discord.Models.IAuditLogOptionsModel? Discord.Models.IAuditLogEntryModel.Options => (AuditLogEntry as Discord.Models.IAuditLogEntryModel).Options;

    string? Discord.Models.IAuditLogEntryModel.Reason => (AuditLogEntry as Discord.Models.IAuditLogEntryModel).Reason;

    ulong Discord.Models.IEntityModel<ulong>.Id => (AuditLogEntry as Discord.Models.IEntityModel<ulong>).Id;
}