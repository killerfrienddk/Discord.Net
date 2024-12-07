using System.Text.Json.Serialization;

namespace Discord.Models.Json;

public sealed partial class GuildUpdated : IExtendedModel<Discord.Models.Json.Guild>
{
    Discord.Models.Json.Guild IExtendedModel<Discord.Models.Json.Guild>.ExtendedValue => Guild;

    string? Discord.Models.IGuildModel.DiscoverySplashId => (Guild as Discord.Models.IGuildModel).DiscoverySplashId;

    ulong Discord.Models.IGuildModel.OwnerId => (Guild as Discord.Models.IGuildModel).OwnerId;

    ulong? Discord.Models.IGuildModel.AFKChannelId => (Guild as Discord.Models.IGuildModel).AFKChannelId;

    int Discord.Models.IGuildModel.AFKTimeout => (Guild as Discord.Models.IGuildModel).AFKTimeout;

    bool Discord.Models.IGuildModel.WidgetEnabled => (Guild as Discord.Models.IGuildModel).WidgetEnabled;

    ulong? Discord.Models.IGuildModel.WidgetChannelId => (Guild as Discord.Models.IGuildModel).WidgetChannelId;

    int Discord.Models.IGuildModel.DefaultMessageNotifications => (Guild as Discord.Models.IGuildModel).DefaultMessageNotifications;

    int Discord.Models.IGuildModel.ExplicitContentFilter => (Guild as Discord.Models.IGuildModel).ExplicitContentFilter;

    int Discord.Models.IGuildModel.MFALevel => (Guild as Discord.Models.IGuildModel).MFALevel;

    ulong? Discord.Models.IGuildModel.ApplicationId => (Guild as Discord.Models.IGuildModel).ApplicationId;

    ulong? Discord.Models.IGuildModel.SystemChannelId => (Guild as Discord.Models.IGuildModel).SystemChannelId;

    int Discord.Models.IGuildModel.SystemChannelFlags => (Guild as Discord.Models.IGuildModel).SystemChannelFlags;

    ulong? Discord.Models.IGuildModel.RulesChannelId => (Guild as Discord.Models.IGuildModel).RulesChannelId;

    int? Discord.Models.IGuildModel.MaxPresence => (Guild as Discord.Models.IGuildModel).MaxPresence;

    int? Discord.Models.IGuildModel.MaxMembers => (Guild as Discord.Models.IGuildModel).MaxMembers;

    int Discord.Models.IGuildModel.PremiumTier => (Guild as Discord.Models.IGuildModel).PremiumTier;

    string Discord.Models.IGuildModel.PreferredLocale => (Guild as Discord.Models.IGuildModel).PreferredLocale;

    ulong? Discord.Models.IGuildModel.PublicUpdatesChannelId => (Guild as Discord.Models.IGuildModel).PublicUpdatesChannelId;

    int? Discord.Models.IGuildModel.MaxVideoChannelUsers => (Guild as Discord.Models.IGuildModel).MaxVideoChannelUsers;

    int? Discord.Models.IGuildModel.MaxStageVideoChannelUsers => (Guild as Discord.Models.IGuildModel).MaxStageVideoChannelUsers;

    Discord.Models.IWelcomeScreenModel? Discord.Models.IGuildModel.WelcomeScreen => (Guild as Discord.Models.IGuildModel).WelcomeScreen;

    bool Discord.Models.IGuildModel.PremiumProgressBarEnabled => (Guild as Discord.Models.IGuildModel).PremiumProgressBarEnabled;

    ulong? Discord.Models.IGuildModel.SafetyAlertsChannelId => (Guild as Discord.Models.IGuildModel).SafetyAlertsChannelId;

    System.Collections.Generic.IEnumerable<ulong> Discord.Models.IGuildModel.RoleIds => (Guild as Discord.Models.IGuildModel).RoleIds;

    System.Collections.Generic.IEnumerable<ulong> Discord.Models.IGuildModel.EmoteIds => (Guild as Discord.Models.IGuildModel).EmoteIds;

    System.Collections.Generic.IEnumerable<ulong> Discord.Models.IGuildModel.StickerIds => (Guild as Discord.Models.IGuildModel).StickerIds;

    string Discord.Models.IPartialGuildModel.Name => (Guild as Discord.Models.IPartialGuildModel).Name;

    string? Discord.Models.IPartialGuildModel.SplashId => (Guild as Discord.Models.IPartialGuildModel).SplashId;

    string? Discord.Models.IPartialGuildModel.BannerId => (Guild as Discord.Models.IPartialGuildModel).BannerId;

    string? Discord.Models.IPartialGuildModel.Description => (Guild as Discord.Models.IPartialGuildModel).Description;

    string? Discord.Models.IPartialGuildModel.IconId => (Guild as Discord.Models.IPartialGuildModel).IconId;

    string[]? Discord.Models.IPartialGuildModel.Features => (Guild as Discord.Models.IPartialGuildModel).Features;

    int? Discord.Models.IPartialGuildModel.VerificationLevel => (Guild as Discord.Models.IPartialGuildModel).VerificationLevel;

    string? Discord.Models.IPartialGuildModel.VanityUrlCode => (Guild as Discord.Models.IPartialGuildModel).VanityUrlCode;

    int? Discord.Models.IPartialGuildModel.NsfwLevel => (Guild as Discord.Models.IPartialGuildModel).NsfwLevel;

    int? Discord.Models.IPartialGuildModel.PremiumSubscriptionCount => (Guild as Discord.Models.IPartialGuildModel).PremiumSubscriptionCount;

    int? Discord.Models.IPartialGuildModel.ApproximateMemberCount => (Guild as Discord.Models.IPartialGuildModel).ApproximateMemberCount;

    int? Discord.Models.IPartialGuildModel.ApproximatePresenceCount => (Guild as Discord.Models.IPartialGuildModel).ApproximatePresenceCount;

    ulong Discord.Models.IEntityModel<ulong>.Id => (Guild as Discord.Models.IEntityModel<ulong>).Id;
}