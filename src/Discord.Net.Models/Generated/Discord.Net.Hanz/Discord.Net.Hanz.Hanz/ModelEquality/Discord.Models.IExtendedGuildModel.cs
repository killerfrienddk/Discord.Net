using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IExtendedGuildModel : 
    IEquatable<Discord.Models.IExtendedGuildModel>
{
    new bool Equals(Discord.Models.IExtendedGuildModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<System.DateTimeOffset>.Default.Equals(this.JoinedAt, other.JoinedAt) &&
            EqualityComparer<bool>.Default.Equals(this.IsLarge, other.IsLarge) &&
            (this.IsUnavailable.IsSpecified == other.IsUnavailable.IsSpecified) && (!this.IsUnavailable.IsSpecified || (EqualityComparer<bool>.Default.Equals(this.IsUnavailable.Value, other.IsUnavailable.Value))) &&
            EqualityComparer<int>.Default.Equals(this.MemberCount, other.MemberCount) &&
            EqualityComparer<System.Collections.Generic.IReadOnlyCollection<IPartialVoiceStateModel>>.Default.Equals(this.VoiceStates, other.VoiceStates) &&
            EqualityComparer<System.Collections.Generic.IReadOnlyCollection<Discord.Models.IMemberModel>>.Default.Equals(this.Members, other.Members) &&
            EqualityComparer<System.Collections.Generic.IReadOnlyCollection<Discord.Models.IGuildChannelModel>>.Default.Equals(this.Channels, other.Channels) &&
            EqualityComparer<System.Collections.Generic.IReadOnlyCollection<Discord.Models.IThreadChannelModel>>.Default.Equals(this.Threads, other.Threads) &&
            EqualityComparer<System.Collections.Generic.IReadOnlyCollection<Discord.Models.IPresenceModel>>.Default.Equals(this.Presences, other.Presences) &&
            EqualityComparer<System.Collections.Generic.IReadOnlyCollection<Discord.Models.IStageInstanceModel>>.Default.Equals(this.StageInstances, other.StageInstances) &&
            EqualityComparer<System.Collections.Generic.IReadOnlyCollection<Discord.Models.IGuildScheduledEventModel>>.Default.Equals(this.GuildScheduledEvents, other.GuildScheduledEvents) &&
            EqualityComparer<System.Collections.Generic.IReadOnlyCollection<Discord.Models.IGuildSoundboardSoundModel>>.Default.Equals(this.SoundboardSounds, other.SoundboardSounds) &&
            EqualityComparer<string>.Default.Equals(this.Name, other.Name) &&
            EqualityComparer<string?>.Default.Equals(this.Icon, other.Icon) &&
            (this.IconHash.IsSpecified == other.IconHash.IsSpecified) && (!this.IconHash.IsSpecified || (EqualityComparer<string?>.Default.Equals(this.IconHash.Value, other.IconHash.Value))) &&
            EqualityComparer<string?>.Default.Equals(this.Splash, other.Splash) &&
            EqualityComparer<string?>.Default.Equals(this.DiscoverySplash, other.DiscoverySplash) &&
            (this.IsOwner.IsSpecified == other.IsOwner.IsSpecified) && (!this.IsOwner.IsSpecified || (EqualityComparer<bool>.Default.Equals(this.IsOwner.Value, other.IsOwner.Value))) &&
            EqualityComparer<ulong>.Default.Equals(this.OwnerId, other.OwnerId) &&
            (this.Permissions.IsSpecified == other.Permissions.IsSpecified) && (!this.Permissions.IsSpecified || (EqualityComparer<string>.Default.Equals(this.Permissions.Value, other.Permissions.Value))) &&
            (this.Region.IsSpecified == other.Region.IsSpecified) && (!this.Region.IsSpecified || (EqualityComparer<string?>.Default.Equals(this.Region.Value, other.Region.Value))) &&
            EqualityComparer<ulong?>.Default.Equals(this.AFKChannelId, other.AFKChannelId) &&
            EqualityComparer<int>.Default.Equals(this.AFKTimeout, other.AFKTimeout) &&
            (this.IsWidgetEnabled.IsSpecified == other.IsWidgetEnabled.IsSpecified) && (!this.IsWidgetEnabled.IsSpecified || (EqualityComparer<bool>.Default.Equals(this.IsWidgetEnabled.Value, other.IsWidgetEnabled.Value))) &&
            (this.WidgetChannelId.IsSpecified == other.WidgetChannelId.IsSpecified) && (!this.WidgetChannelId.IsSpecified || (EqualityComparer<ulong?>.Default.Equals(this.WidgetChannelId.Value, other.WidgetChannelId.Value))) &&
            EqualityComparer<int>.Default.Equals(this.VerificationLevel, other.VerificationLevel) &&
            EqualityComparer<int>.Default.Equals(this.DefaultMessageNotifications, other.DefaultMessageNotifications) &&
            EqualityComparer<int>.Default.Equals(this.ExplicitContentFilterLevel, other.ExplicitContentFilterLevel) &&
            EqualityComparer<System.Collections.Generic.IReadOnlyCollection<Discord.Models.ModelOrId<Discord.Models.IRoleModel, ulong>>>.Default.Equals(this.Roles, other.Roles) &&
            EqualityComparer<System.Collections.Generic.IReadOnlyCollection<Discord.Models.ModelOrId<Discord.Models.ICustomEmoteModel, ulong>>>.Default.Equals(this.Emojis, other.Emojis) &&
            (this.Features is null == other.Features is null) && (this.Features is null || this.Features.SequenceEqual(other.Features!)) &&
            EqualityComparer<int>.Default.Equals(this.MFALevel, other.MFALevel) &&
            EqualityComparer<ulong?>.Default.Equals(this.ApplicationId, other.ApplicationId) &&
            EqualityComparer<ulong?>.Default.Equals(this.SystemChannelId, other.SystemChannelId) &&
            EqualityComparer<int>.Default.Equals(this.SystemChannelFlags, other.SystemChannelFlags) &&
            EqualityComparer<ulong?>.Default.Equals(this.RulesChannelId, other.RulesChannelId) &&
            (this.MaxPresences.IsSpecified == other.MaxPresences.IsSpecified) && (!this.MaxPresences.IsSpecified || (EqualityComparer<int?>.Default.Equals(this.MaxPresences.Value, other.MaxPresences.Value))) &&
            (this.MaxMembers.IsSpecified == other.MaxMembers.IsSpecified) && (!this.MaxMembers.IsSpecified || (EqualityComparer<int>.Default.Equals(this.MaxMembers.Value, other.MaxMembers.Value))) &&
            EqualityComparer<string?>.Default.Equals(this.VanityUrlCode, other.VanityUrlCode) &&
            EqualityComparer<string?>.Default.Equals(this.Description, other.Description) &&
            EqualityComparer<string?>.Default.Equals(this.Banner, other.Banner) &&
            EqualityComparer<int>.Default.Equals(this.PremiumTier, other.PremiumTier) &&
            (this.PremiumSubscriptionCount.IsSpecified == other.PremiumSubscriptionCount.IsSpecified) && (!this.PremiumSubscriptionCount.IsSpecified || (EqualityComparer<int>.Default.Equals(this.PremiumSubscriptionCount.Value, other.PremiumSubscriptionCount.Value))) &&
            EqualityComparer<string>.Default.Equals(this.PreferredLocale, other.PreferredLocale) &&
            EqualityComparer<ulong?>.Default.Equals(this.PublicUpdatesChannelId, other.PublicUpdatesChannelId) &&
            (this.MaxVideoChannelUsers.IsSpecified == other.MaxVideoChannelUsers.IsSpecified) && (!this.MaxVideoChannelUsers.IsSpecified || (EqualityComparer<int>.Default.Equals(this.MaxVideoChannelUsers.Value, other.MaxVideoChannelUsers.Value))) &&
            (this.MaxStageChannelUsers.IsSpecified == other.MaxStageChannelUsers.IsSpecified) && (!this.MaxStageChannelUsers.IsSpecified || (EqualityComparer<int>.Default.Equals(this.MaxStageChannelUsers.Value, other.MaxStageChannelUsers.Value))) &&
            (this.ApproximateMemberCount.IsSpecified == other.ApproximateMemberCount.IsSpecified) && (!this.ApproximateMemberCount.IsSpecified || (EqualityComparer<int>.Default.Equals(this.ApproximateMemberCount.Value, other.ApproximateMemberCount.Value))) &&
            (this.ApproximatePresenceCount.IsSpecified == other.ApproximatePresenceCount.IsSpecified) && (!this.ApproximatePresenceCount.IsSpecified || (EqualityComparer<int>.Default.Equals(this.ApproximatePresenceCount.Value, other.ApproximatePresenceCount.Value))) &&
            (this.WelcomeScreen.IsSpecified == other.WelcomeScreen.IsSpecified) && (!this.WelcomeScreen.IsSpecified || (EqualityComparer<Discord.Models.IWelcomeScreenModel>.Default.Equals(this.WelcomeScreen.Value, other.WelcomeScreen.Value))) &&
            EqualityComparer<int>.Default.Equals(this.NSFWLevel, other.NSFWLevel) &&
            (this.Stickers.IsSpecified == other.Stickers.IsSpecified) && (!this.Stickers.IsSpecified || (EqualityComparer<System.Collections.Generic.IReadOnlyCollection<Discord.Models.ModelOrId<Discord.Models.IGuildStickerModel, ulong>>>.Default.Equals(this.Stickers.Value, other.Stickers.Value))) &&
            EqualityComparer<bool>.Default.Equals(this.IsPremiumProgressBarEnabled, other.IsPremiumProgressBarEnabled) &&
            EqualityComparer<ulong?>.Default.Equals(this.SafetyAlertsChannelId, other.SafetyAlertsChannelId);
    }
    

    bool IEquatable<Discord.Models.IExtendedGuildModel>.Equals(Discord.Models.IExtendedGuildModel? other) => Equals(other);

    bool IEquatable<Discord.Models.IGuildModel>.Equals(Discord.Models.IGuildModel? other) => other is Discord.Models.IExtendedGuildModel self && Equals(self);

    bool Discord.Models.IGuildModel.Equals(Discord.Models.IGuildModel? other) => other is Discord.Models.IExtendedGuildModel self && Equals(self);
}
