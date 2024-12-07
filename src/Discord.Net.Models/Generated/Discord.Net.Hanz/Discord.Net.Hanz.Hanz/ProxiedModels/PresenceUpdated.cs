using System.Text.Json.Serialization;

namespace Discord.Models.Json;

public sealed partial class PresenceUpdated : IExtendedModel<Discord.Models.Json.Presence>
{
    Discord.Models.Json.Presence IExtendedModel<Discord.Models.Json.Presence>.ExtendedValue => Presence;

    ulong Discord.Models.IPresenceModel.UserId => (Presence as Discord.Models.IPresenceModel).UserId;

    ulong? Discord.Models.IPresenceModel.GuildId => (Presence as Discord.Models.IPresenceModel).GuildId;

    string? Discord.Models.IPresenceModel.Status => (Presence as Discord.Models.IPresenceModel).Status;

    System.Collections.Generic.IEnumerable<Discord.Models.IActivityModel>? Discord.Models.IPresenceModel.Activities => (Presence as Discord.Models.IPresenceModel).Activities;

    Discord.Models.IClientStatusModel? Discord.Models.IPresenceModel.ClientStatus => (Presence as Discord.Models.IPresenceModel).ClientStatus;
}