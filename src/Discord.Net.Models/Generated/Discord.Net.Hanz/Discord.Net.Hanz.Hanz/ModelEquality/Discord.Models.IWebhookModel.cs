using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IWebhookModel : 
    IEquatable<Discord.Models.IWebhookModel>
{
    new bool Equals(Discord.Models.IWebhookModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<int>.Default.Equals(this.Type, other.Type) &&
            (this.User.IsSpecified == other.User.IsSpecified) && (!this.User.IsSpecified || (EqualityComparer<Discord.Models.ModelOrId<Discord.Models.IUserModel, ulong>>.Default.Equals(this.User.Value, other.User.Value))) &&
            EqualityComparer<string?>.Default.Equals(this.Name, other.Name) &&
            EqualityComparer<string?>.Default.Equals(this.Avatar, other.Avatar) &&
            EqualityComparer<ulong?>.Default.Equals(this.ApplicationId, other.ApplicationId);
    }
    

    bool IEquatable<Discord.Models.IWebhookModel>.Equals(Discord.Models.IWebhookModel? other) => Equals(other);
}
