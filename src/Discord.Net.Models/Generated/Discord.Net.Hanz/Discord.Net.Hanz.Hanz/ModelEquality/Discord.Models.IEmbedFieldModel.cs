using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IEmbedFieldModel : 
    IEquatable<Discord.Models.IEmbedFieldModel>
{
    new bool Equals(Discord.Models.IEmbedFieldModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<string>.Default.Equals(this.Name, other.Name) &&
            EqualityComparer<string>.Default.Equals(this.Value, other.Value) &&
            (this.Inline.IsSpecified == other.Inline.IsSpecified) && (!this.Inline.IsSpecified || (EqualityComparer<bool>.Default.Equals(this.Inline.Value, other.Inline.Value)));
    }
    

    bool IEquatable<Discord.Models.IEmbedFieldModel>.Equals(Discord.Models.IEmbedFieldModel? other) => Equals(other);
}
