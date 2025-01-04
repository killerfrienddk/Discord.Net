using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IGuildStickerModel : 
    IEquatable<Discord.Models.IGuildStickerModel>
{
    new bool Equals(Discord.Models.IGuildStickerModel? other)
    {
        if(other is null) return false;
        
        return
            (this.Available.IsSpecified == other.Available.IsSpecified) && (!this.Available.IsSpecified || (EqualityComparer<bool>.Default.Equals(this.Available.Value, other.Available.Value))) &&
            EqualityComparer<ulong>.Default.Equals(this.GuildId, other.GuildId) &&
            (this.User.IsSpecified == other.User.IsSpecified) && (!this.User.IsSpecified || (EqualityComparer<Discord.Models.ModelOrId<Discord.Models.IUserModel, ulong>>.Default.Equals(this.User.Value, other.User.Value))) &&
            (this.PackId.IsSpecified == other.PackId.IsSpecified) && (!this.PackId.IsSpecified || (EqualityComparer<ulong>.Default.Equals(this.PackId.Value, other.PackId.Value))) &&
            EqualityComparer<string>.Default.Equals(this.Name, other.Name) &&
            EqualityComparer<string?>.Default.Equals(this.Description, other.Description) &&
            EqualityComparer<string>.Default.Equals(this.Tags, other.Tags) &&
            EqualityComparer<int>.Default.Equals(this.Type, other.Type) &&
            EqualityComparer<int>.Default.Equals(this.FormatType, other.FormatType) &&
            (this.SortValue.IsSpecified == other.SortValue.IsSpecified) && (!this.SortValue.IsSpecified || (EqualityComparer<int>.Default.Equals(this.SortValue.Value, other.SortValue.Value)));
    }
    

    bool IEquatable<Discord.Models.IGuildStickerModel>.Equals(Discord.Models.IGuildStickerModel? other) => Equals(other);

    bool IEquatable<Discord.Models.IStickerModel>.Equals(Discord.Models.IStickerModel? other) => other is Discord.Models.IGuildStickerModel self && Equals(self);

    bool Discord.Models.IStickerModel.Equals(Discord.Models.IStickerModel? other) => other is Discord.Models.IGuildStickerModel self && Equals(self);
}
