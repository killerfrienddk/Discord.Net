using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface ISubCommandGroupApplicationCommandOptionModel : 
    IEquatable<Discord.Models.ISubCommandGroupApplicationCommandOptionModel>
{
    new bool Equals(Discord.Models.ISubCommandGroupApplicationCommandOptionModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<System.Collections.Generic.IReadOnlyCollection<Discord.Models.IApplicationCommandOptionModel>>.Default.Equals(this.Options, other.Options) &&
            EqualityComparer<int>.Default.Equals(this.Type, other.Type) &&
            EqualityComparer<string>.Default.Equals(this.Name, other.Name) &&
            (this.NameLocalizations.IsSpecified == other.NameLocalizations.IsSpecified) && (!this.NameLocalizations.IsSpecified || ((this.NameLocalizations.Value is null == other.NameLocalizations.Value is null) && (this.NameLocalizations.Value is null || (this.NameLocalizations.Value.Count == other.NameLocalizations.Value.Count && this.NameLocalizations.Value.All(kvp => other.NameLocalizations.Value.ContainsKey(kvp.Key) && EqualityComparer<string>.Default.Equals(kvp.Value, other.NameLocalizations.Value[kvp.Key])))))) &&
            EqualityComparer<string>.Default.Equals(this.Description, other.Description) &&
            (this.DescriptionLocalizations.IsSpecified == other.DescriptionLocalizations.IsSpecified) && (!this.DescriptionLocalizations.IsSpecified || ((this.DescriptionLocalizations.Value is null == other.DescriptionLocalizations.Value is null) && (this.DescriptionLocalizations.Value is null || (this.DescriptionLocalizations.Value.Count == other.DescriptionLocalizations.Value.Count && this.DescriptionLocalizations.Value.All(kvp => other.DescriptionLocalizations.Value.ContainsKey(kvp.Key) && EqualityComparer<string>.Default.Equals(kvp.Value, other.DescriptionLocalizations.Value[kvp.Key]))))));
    }
    

    bool IEquatable<Discord.Models.ISubCommandGroupApplicationCommandOptionModel>.Equals(Discord.Models.ISubCommandGroupApplicationCommandOptionModel? other) => Equals(other);

    bool IEquatable<Discord.Models.IApplicationCommandOptionModel>.Equals(Discord.Models.IApplicationCommandOptionModel? other) => other is Discord.Models.ISubCommandGroupApplicationCommandOptionModel self && Equals(self);

    bool Discord.Models.IApplicationCommandOptionModel.Equals(Discord.Models.IApplicationCommandOptionModel? other) => other is Discord.Models.ISubCommandGroupApplicationCommandOptionModel self && Equals(self);
}
