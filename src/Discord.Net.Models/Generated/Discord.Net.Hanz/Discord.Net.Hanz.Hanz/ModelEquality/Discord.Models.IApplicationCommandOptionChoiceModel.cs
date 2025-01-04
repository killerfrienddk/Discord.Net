using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IApplicationCommandOptionChoiceModel : 
    IEquatable<Discord.Models.IApplicationCommandOptionChoiceModel>
{
    new bool Equals(Discord.Models.IApplicationCommandOptionChoiceModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<string>.Default.Equals(this.Name, other.Name) &&
            (this.NameLocalization.IsSpecified == other.NameLocalization.IsSpecified) && (!this.NameLocalization.IsSpecified || ((this.NameLocalization.Value is null == other.NameLocalization.Value is null) && (this.NameLocalization.Value is null || (this.NameLocalization.Value.Count == other.NameLocalization.Value.Count && this.NameLocalization.Value.All(kvp => other.NameLocalization.Value.ContainsKey(kvp.Key) && EqualityComparer<string>.Default.Equals(kvp.Value, other.NameLocalization.Value[kvp.Key])))))) &&
            EqualityComparer<object>.Default.Equals(this.Value, other.Value);
    }
    

    bool IEquatable<Discord.Models.IApplicationCommandOptionChoiceModel>.Equals(Discord.Models.IApplicationCommandOptionChoiceModel? other) => Equals(other);
}
