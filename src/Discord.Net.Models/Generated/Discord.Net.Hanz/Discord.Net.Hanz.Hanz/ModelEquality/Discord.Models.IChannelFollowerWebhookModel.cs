using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IChannelFollowerWebhookModel : 
    IEquatable<Discord.Models.IChannelFollowerWebhookModel>
{
    new bool Equals(Discord.Models.IChannelFollowerWebhookModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<ulong>.Default.Equals(this.GuildId, other.GuildId) &&
            EqualityComparer<ulong>.Default.Equals(this.ChannelId, other.ChannelId) &&
            (this.SourceGuild.IsSpecified == other.SourceGuild.IsSpecified) && (!this.SourceGuild.IsSpecified || (EqualityComparer<Discord.Models.ModelOrId<IPartialGuildModel, ulong>>.Default.Equals(this.SourceGuild.Value, other.SourceGuild.Value))) &&
            (this.SourceChannel.IsSpecified == other.SourceChannel.IsSpecified) && (!this.SourceChannel.IsSpecified || (EqualityComparer<Discord.Models.ModelOrId<IPartialChannelModel, ulong>>.Default.Equals(this.SourceChannel.Value, other.SourceChannel.Value))) &&
            EqualityComparer<int>.Default.Equals(this.Type, other.Type) &&
            (this.User.IsSpecified == other.User.IsSpecified) && (!this.User.IsSpecified || (EqualityComparer<Discord.Models.ModelOrId<Discord.Models.IUserModel, ulong>>.Default.Equals(this.User.Value, other.User.Value))) &&
            EqualityComparer<string?>.Default.Equals(this.Name, other.Name) &&
            EqualityComparer<string?>.Default.Equals(this.Avatar, other.Avatar) &&
            EqualityComparer<ulong?>.Default.Equals(this.ApplicationId, other.ApplicationId);
    }
    

    bool IEquatable<Discord.Models.IChannelFollowerWebhookModel>.Equals(Discord.Models.IChannelFollowerWebhookModel? other) => Equals(other);

    bool IEquatable<Discord.Models.IWebhookModel>.Equals(Discord.Models.IWebhookModel? other) => other is Discord.Models.IChannelFollowerWebhookModel self && Equals(self);

    bool Discord.Models.IWebhookModel.Equals(Discord.Models.IWebhookModel? other) => other is Discord.Models.IChannelFollowerWebhookModel self && Equals(self);
}
