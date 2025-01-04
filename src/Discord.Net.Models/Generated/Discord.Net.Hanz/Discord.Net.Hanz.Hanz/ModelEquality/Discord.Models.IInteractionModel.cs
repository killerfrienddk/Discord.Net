using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IInteractionModel : 
    IEquatable<Discord.Models.IInteractionModel>
{
    new bool Equals(Discord.Models.IInteractionModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<ulong>.Default.Equals(this.ApplicationId, other.ApplicationId) &&
            EqualityComparer<int>.Default.Equals(this.Type, other.Type) &&
            (this.Data.IsSpecified == other.Data.IsSpecified) && (!this.Data.IsSpecified || (EqualityComparer<Discord.Models.IInteractionDataModel>.Default.Equals(this.Data.Value, other.Data.Value))) &&
            (this.Guild.IsSpecified == other.Guild.IsSpecified) && (!this.Guild.IsSpecified || (EqualityComparer<Discord.Models.ModelOrId<IPartialGuildModel, ulong>>.Default.Equals(this.Guild.Value, other.Guild.Value))) &&
            (this.Channel.IsSpecified == other.Channel.IsSpecified) && (!this.Channel.IsSpecified || (EqualityComparer<Discord.Models.ModelOrId<IPartialChannelModel, ulong>>.Default.Equals(this.Channel.Value, other.Channel.Value))) &&
            (this.User.IsSpecified == other.User.IsSpecified) && (!this.User.IsSpecified || (EqualityComparer<Discord.Models.ModelOrId<Discord.Models.IUserModel, ulong>>.Default.Equals(this.User.Value, other.User.Value))) &&
            (this.Member.IsSpecified == other.Member.IsSpecified) && (!this.Member.IsSpecified || (EqualityComparer<Discord.Models.ModelOrId<Discord.Models.IMemberModel, ulong>>.Default.Equals(this.Member.Value, other.Member.Value))) &&
            EqualityComparer<string>.Default.Equals(this.Token, other.Token) &&
            EqualityComparer<int>.Default.Equals(this.Version, other.Version) &&
            (this.Message.IsSpecified == other.Message.IsSpecified) && (!this.Message.IsSpecified || (EqualityComparer<Discord.Models.ModelOrId<Discord.Models.IMessageModel, ulong>>.Default.Equals(this.Message.Value, other.Message.Value))) &&
            EqualityComparer<string>.Default.Equals(this.AppPermissions, other.AppPermissions) &&
            (this.Locale.IsSpecified == other.Locale.IsSpecified) && (!this.Locale.IsSpecified || (EqualityComparer<string>.Default.Equals(this.Locale.Value, other.Locale.Value))) &&
            (this.GuildLocale.IsSpecified == other.GuildLocale.IsSpecified) && (!this.GuildLocale.IsSpecified || (EqualityComparer<string>.Default.Equals(this.GuildLocale.Value, other.GuildLocale.Value))) &&
            EqualityComparer<System.Collections.Generic.IReadOnlyCollection<Discord.Models.IEntitlementModel>>.Default.Equals(this.Entitlements, other.Entitlements) &&
            EqualityComparer<Discord.Models.IApplicationIntegrationTypes>.Default.Equals(this.AuthorizingIntegrationOwners, other.AuthorizingIntegrationOwners) &&
            (this.Context.IsSpecified == other.Context.IsSpecified) && (!this.Context.IsSpecified || (EqualityComparer<int>.Default.Equals(this.Context.Value, other.Context.Value)));
    }
    

    bool IEquatable<Discord.Models.IInteractionModel>.Equals(Discord.Models.IInteractionModel? other) => Equals(other);
}
