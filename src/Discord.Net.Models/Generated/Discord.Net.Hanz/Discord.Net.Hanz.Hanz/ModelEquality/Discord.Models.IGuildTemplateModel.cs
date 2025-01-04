using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IGuildTemplateModel : 
    IEquatable<Discord.Models.IGuildTemplateModel>
{
    new bool Equals(Discord.Models.IGuildTemplateModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<string>.Default.Equals(this.Name, other.Name) &&
            EqualityComparer<string?>.Default.Equals(this.Description, other.Description) &&
            EqualityComparer<int>.Default.Equals(this.UsageCount, other.UsageCount) &&
            EqualityComparer<Discord.Models.ModelOrId<Discord.Models.IUserModel, ulong>>.Default.Equals(this.Creator, other.Creator) &&
            EqualityComparer<System.DateTimeOffset>.Default.Equals(this.CreatedAt, other.CreatedAt) &&
            EqualityComparer<System.DateTimeOffset>.Default.Equals(this.UpdatedAt, other.UpdatedAt) &&
            EqualityComparer<ulong>.Default.Equals(this.SourceGuildId, other.SourceGuildId) &&
            EqualityComparer<bool?>.Default.Equals(this.IsDirty, other.IsDirty);
    }
    

    bool IEquatable<Discord.Models.IGuildTemplateModel>.Equals(Discord.Models.IGuildTemplateModel? other) => Equals(other);
}
