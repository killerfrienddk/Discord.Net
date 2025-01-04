using System.Text.Json.Serialization;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IPartialGuildModel : 
    IPartialModel,
    IEntityModel<ulong>
{
    Discord.Optional<string> Name { get; }

    Discord.Optional<string?> Icon { get; }

    Discord.Optional<string?> IconHash { get; }

    Discord.Optional<string?> Splash { get; }

    Discord.Optional<string?> DiscoverySplash { get; }

    Discord.Optional<bool> IsOwner { get; }

    Discord.Optional<ulong> OwnerId { get; }

    Discord.Optional<string> Permissions { get; }

    Discord.Optional<string?> Region { get; }

    Discord.Optional<ulong?> AFKChannelId { get; }

    Discord.Optional<int> AFKTimeout { get; }

    Discord.Optional<bool> IsWidgetEnabled { get; }

    Discord.Optional<ulong?> WidgetChannelId { get; }

    Discord.Optional<int> VerificationLevel { get; }

    Discord.Optional<int> DefaultMessageNotifications { get; }

    Discord.Optional<int> ExplicitContentFilterLevel { get; }

    Discord.Optional<System.Collections.Generic.IReadOnlyCollection<Discord.Models.ModelOrId<Discord.Models.IRoleModel, ulong>>> Roles { get; }

    Discord.Optional<System.Collections.Generic.IReadOnlyCollection<Discord.Models.ModelOrId<Discord.Models.ICustomEmoteModel, ulong>>> Emojis { get; }

    Discord.Optional<string[]> Features { get; }

    Discord.Optional<int> MFALevel { get; }

    Discord.Optional<ulong?> ApplicationId { get; }

    Discord.Optional<ulong?> SystemChannelId { get; }

    Discord.Optional<int> SystemChannelFlags { get; }

    Discord.Optional<ulong?> RulesChannelId { get; }

    Discord.Optional<int?> MaxPresences { get; }

    Discord.Optional<int> MaxMembers { get; }

    Discord.Optional<string?> VanityUrlCode { get; }

    Discord.Optional<string?> Description { get; }

    Discord.Optional<string?> Banner { get; }

    Discord.Optional<int> PremiumTier { get; }

    Discord.Optional<int> PremiumSubscriptionCount { get; }

    Discord.Optional<string> PreferredLocale { get; }

    Discord.Optional<ulong?> PublicUpdatesChannelId { get; }

    Discord.Optional<int> MaxVideoChannelUsers { get; }

    Discord.Optional<int> MaxStageChannelUsers { get; }

    Discord.Optional<int> ApproximateMemberCount { get; }

    Discord.Optional<int> ApproximatePresenceCount { get; }

    Discord.Optional<Discord.Models.IWelcomeScreenModel> WelcomeScreen { get; }

    Discord.Optional<int> NSFWLevel { get; }

    Discord.Optional<System.Collections.Generic.IReadOnlyCollection<Discord.Models.ModelOrId<Discord.Models.IGuildStickerModel, ulong>>> Stickers { get; }

    Discord.Optional<bool> IsPremiumProgressBarEnabled { get; }

    Discord.Optional<ulong?> SafetyAlertsChannelId { get; }

    Type IPartialModel.UnderlyingModelType => typeof(Discord.Models.IGuildModel);
}
