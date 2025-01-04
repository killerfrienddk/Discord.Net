using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IRoleModel : 
    IEquatable<Discord.Models.IRoleModel>
{
    new bool Equals(Discord.Models.IRoleModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<string>.Default.Equals(this.Name, other.Name) &&
            EqualityComparer<uint>.Default.Equals(this.Color, other.Color) &&
            EqualityComparer<bool>.Default.Equals(this.IsHoisted, other.IsHoisted) &&
            (this.Icon.IsSpecified == other.Icon.IsSpecified) && (!this.Icon.IsSpecified || (EqualityComparer<string>.Default.Equals(this.Icon.Value, other.Icon.Value))) &&
            (this.UnicodeEmoji.IsSpecified == other.UnicodeEmoji.IsSpecified) && (!this.UnicodeEmoji.IsSpecified || (EqualityComparer<string>.Default.Equals(this.UnicodeEmoji.Value, other.UnicodeEmoji.Value))) &&
            EqualityComparer<int>.Default.Equals(this.Position, other.Position) &&
            EqualityComparer<string>.Default.Equals(this.Permissions, other.Permissions) &&
            EqualityComparer<bool>.Default.Equals(this.IsManaged, other.IsManaged) &&
            EqualityComparer<bool>.Default.Equals(this.IsMentionable, other.IsMentionable) &&
            EqualityComparer<int>.Default.Equals(this.Flags, other.Flags) &&
            (this.Tags.IsSpecified == other.Tags.IsSpecified) && (!this.Tags.IsSpecified || (EqualityComparer<Discord.Models.IRoleTagsModel>.Default.Equals(this.Tags.Value, other.Tags.Value)));
    }
    

    bool IEquatable<Discord.Models.IRoleModel>.Equals(Discord.Models.IRoleModel? other) => Equals(other);
}
