using System.Text.Json.Serialization;

namespace Discord.Models.Json;

public sealed partial class InteractionCreated : IExtendedModel<Discord.Models.Json.Interaction>
{
    Discord.Models.Json.Interaction IExtendedModel<Discord.Models.Json.Interaction>.ExtendedValue => Interaction;

    ulong Discord.Models.IInteractionModel.ApplicationId => (Interaction as Discord.Models.IInteractionModel).ApplicationId;

    int Discord.Models.IInteractionModel.Type => (Interaction as Discord.Models.IInteractionModel).Type;

    Discord.Models.IInteractionDataModel? Discord.Models.IInteractionModel.Data => (Interaction as Discord.Models.IInteractionModel).Data;

    ulong? Discord.Models.IInteractionModel.GuildId => (Interaction as Discord.Models.IInteractionModel).GuildId;

    ulong? Discord.Models.IInteractionModel.ChannelId => (Interaction as Discord.Models.IInteractionModel).ChannelId;

    ulong? Discord.Models.IInteractionModel.UserId => (Interaction as Discord.Models.IInteractionModel).UserId;

    string Discord.Models.IInteractionModel.Token => (Interaction as Discord.Models.IInteractionModel).Token;

    int Discord.Models.IInteractionModel.Version => (Interaction as Discord.Models.IInteractionModel).Version;

    ulong? Discord.Models.IInteractionModel.MessageId => (Interaction as Discord.Models.IInteractionModel).MessageId;

    string? Discord.Models.IInteractionModel.AppPermissions => (Interaction as Discord.Models.IInteractionModel).AppPermissions;

    string? Discord.Models.IInteractionModel.Locale => (Interaction as Discord.Models.IInteractionModel).Locale;

    string? Discord.Models.IInteractionModel.GuildLocale => (Interaction as Discord.Models.IInteractionModel).GuildLocale;

    System.Collections.Generic.IEnumerable<Discord.Models.IEntitlementModel> Discord.Models.IInteractionModel.Entitlements => (Interaction as Discord.Models.IInteractionModel).Entitlements;

    Discord.Models.IApplicationIntegrationTypes? Discord.Models.IInteractionModel.AuthorizingIntegrationOwners => (Interaction as Discord.Models.IInteractionModel).AuthorizingIntegrationOwners;

    int Discord.Models.IInteractionModel.Context => (Interaction as Discord.Models.IInteractionModel).Context;

    ulong Discord.Models.IEntityModel<ulong>.Id => (Interaction as Discord.Models.IEntityModel<ulong>).Id;
}