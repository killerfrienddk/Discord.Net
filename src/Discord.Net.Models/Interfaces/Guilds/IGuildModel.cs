namespace Discord.Models;

[ModelEquality, HasPartialVariant]
public partial interface IGuildModel : IEntityModel<ulong>
{
    string Name { get; }
    string? Icon { get; }
    Optional<string?> IconHash { get; }
    string? Splash { get; }
    string? DiscoverySplash { get; }
    Optional<bool> IsOwner { get; }
    ulong OwnerId { get; }
    Optional<string> Permissions { get; }
    Optional<string?> Region { get; }
    ulong? AFKChannelId { get; }
    int AFKTimeout { get; }
    Optional<bool> IsWidgetEnabled { get; }
    Optional<ulong?> WidgetChannelId { get; }
    int VerificationLevel { get; }
    int DefaultMessageNotifications { get; }
    int ExplicitContentFilterLevel { get; }
    IReadOnlyCollection<ModelOrId<IRoleModel, ulong>> Roles { get; }
    IReadOnlyCollection<ModelOrId<ICustomEmoteModel, ulong>> Emojis { get; }
    string[] Features { get; }
    int MFALevel { get; }
    ulong? ApplicationId { get; }
    ulong? SystemChannelId { get; }
    int SystemChannelFlags { get; }
    ulong? RulesChannelId { get; }
    Optional<int?> MaxPresences { get; }
    Optional<int> MaxMembers { get; }
    string? VanityUrlCode { get; }
    string? Description { get; }
    string? Banner { get; }
    int PremiumTier { get; }
    Optional<int> PremiumSubscriptionCount { get; }
    string PreferredLocale { get; }
    ulong? PublicUpdatesChannelId { get; }
    Optional<int> MaxVideoChannelUsers { get; }
    Optional<int> MaxStageChannelUsers { get; }
    Optional<int> ApproximateMemberCount { get; }
    Optional<int> ApproximatePresenceCount { get; }
    Optional<IWelcomeScreenModel> WelcomeScreen { get; }
    int NSFWLevel { get; }
    Optional<IReadOnlyCollection<ModelOrId<IGuildStickerModel, ulong>>> Stickers { get; }
    bool IsPremiumProgressBarEnabled { get; }
    ulong? SafetyAlertsChannelId { get; }
}