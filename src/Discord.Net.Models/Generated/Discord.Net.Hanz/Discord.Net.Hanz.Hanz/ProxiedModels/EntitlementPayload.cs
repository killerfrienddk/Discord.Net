using System.Text.Json.Serialization;

namespace Discord.Models.Json;

public sealed partial class EntitlementPayload : IExtendedModel<Discord.Models.Json.Entitlement>
{
    Discord.Models.Json.Entitlement IExtendedModel<Discord.Models.Json.Entitlement>.ExtendedValue => Entitlement;

    ulong Discord.Models.IEntitlementModel.SkuId => (Entitlement as Discord.Models.IEntitlementModel).SkuId;

    ulong Discord.Models.IEntitlementModel.ApplicationId => (Entitlement as Discord.Models.IEntitlementModel).ApplicationId;

    ulong? Discord.Models.IEntitlementModel.UserId => (Entitlement as Discord.Models.IEntitlementModel).UserId;

    int Discord.Models.IEntitlementModel.Type => (Entitlement as Discord.Models.IEntitlementModel).Type;

    bool Discord.Models.IEntitlementModel.IsDeleted => (Entitlement as Discord.Models.IEntitlementModel).IsDeleted;

    System.DateTimeOffset? Discord.Models.IEntitlementModel.StartsAt => (Entitlement as Discord.Models.IEntitlementModel).StartsAt;

    System.DateTimeOffset? Discord.Models.IEntitlementModel.EndsAt => (Entitlement as Discord.Models.IEntitlementModel).EndsAt;

    ulong? Discord.Models.IEntitlementModel.GuildId => (Entitlement as Discord.Models.IEntitlementModel).GuildId;

    bool? Discord.Models.IEntitlementModel.Consumed => (Entitlement as Discord.Models.IEntitlementModel).Consumed;

    ulong Discord.Models.IEntityModel<ulong>.Id => (Entitlement as Discord.Models.IEntityModel<ulong>).Id;
}