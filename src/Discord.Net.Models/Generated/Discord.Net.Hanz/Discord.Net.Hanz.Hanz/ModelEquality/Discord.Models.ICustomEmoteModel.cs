using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface ICustomEmoteModel : 
    IEquatable<Discord.Models.ICustomEmoteModel>
{
    new bool Equals(Discord.Models.ICustomEmoteModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<ulong>.Default.Equals(this.Id, other.Id) &&
            (this.Roles is null == other.Roles is null) && (this.Roles is null || this.Roles.SequenceEqual(other.Roles!)) &&
            EqualityComparer<bool>.Default.Equals(this.RequireColons, other.RequireColons) &&
            EqualityComparer<bool>.Default.Equals(this.IsManaged, other.IsManaged) &&
            EqualityComparer<bool>.Default.Equals(this.IsAnimated, other.IsAnimated) &&
            EqualityComparer<bool>.Default.Equals(this.IsAvailable, other.IsAvailable) &&
            (this.User.IsSpecified == other.User.IsSpecified) && (!this.User.IsSpecified || (EqualityComparer<Discord.Models.ModelOrId<Discord.Models.IUserModel, ulong>>.Default.Equals(this.User.Value, other.User.Value))) &&
            EqualityComparer<string>.Default.Equals(this.Name, other.Name);
    }
    

    bool IEquatable<Discord.Models.ICustomEmoteModel>.Equals(Discord.Models.ICustomEmoteModel? other) => Equals(other);

    bool IEquatable<Discord.Models.IEmoteModel>.Equals(Discord.Models.IEmoteModel? other) => other is Discord.Models.ICustomEmoteModel self && Equals(self);

    bool Discord.Models.IEmoteModel.Equals(Discord.Models.IEmoteModel? other) => other is Discord.Models.ICustomEmoteModel self && Equals(self);
}
