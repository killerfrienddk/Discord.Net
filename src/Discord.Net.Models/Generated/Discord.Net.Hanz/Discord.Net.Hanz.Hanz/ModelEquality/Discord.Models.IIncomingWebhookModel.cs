using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IIncomingWebhookModel : 
    IEquatable<Discord.Models.IIncomingWebhookModel>
{
    new bool Equals(Discord.Models.IIncomingWebhookModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<ulong>.Default.Equals(this.GuildId, other.GuildId) &&
            EqualityComparer<ulong>.Default.Equals(this.ChannelId, other.ChannelId) &&
            EqualityComparer<string>.Default.Equals(this.Url, other.Url) &&
            EqualityComparer<string>.Default.Equals(this.Token, other.Token) &&
            EqualityComparer<int>.Default.Equals(this.Type, other.Type) &&
            (this.User.IsSpecified == other.User.IsSpecified) && (!this.User.IsSpecified || (EqualityComparer<Discord.Models.ModelOrId<Discord.Models.IUserModel, ulong>>.Default.Equals(this.User.Value, other.User.Value))) &&
            EqualityComparer<string?>.Default.Equals(this.Name, other.Name) &&
            EqualityComparer<string?>.Default.Equals(this.Avatar, other.Avatar) &&
            EqualityComparer<ulong?>.Default.Equals(this.ApplicationId, other.ApplicationId);
    }
    

    bool IEquatable<Discord.Models.IIncomingWebhookModel>.Equals(Discord.Models.IIncomingWebhookModel? other) => Equals(other);

    bool IEquatable<Discord.Models.IWebhookModel>.Equals(Discord.Models.IWebhookModel? other) => other is Discord.Models.IIncomingWebhookModel self && Equals(self);

    bool Discord.Models.IWebhookModel.Equals(Discord.Models.IWebhookModel? other) => other is Discord.Models.IIncomingWebhookModel self && Equals(self);
}
