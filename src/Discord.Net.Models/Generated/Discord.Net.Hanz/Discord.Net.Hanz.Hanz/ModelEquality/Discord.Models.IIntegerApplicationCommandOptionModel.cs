using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IIntegerApplicationCommandOptionModel : 
    IEquatable<Discord.Models.IIntegerApplicationCommandOptionModel>
{
    new bool Equals(Discord.Models.IIntegerApplicationCommandOptionModel? other)
    {
        if(other is null) return false;
        
        return
            (this.IsRequired.IsSpecified == other.IsRequired.IsSpecified) && (!this.IsRequired.IsSpecified || (EqualityComparer<bool>.Default.Equals(this.IsRequired.Value, other.IsRequired.Value))) &&
            (this.Choices.IsSpecified == other.Choices.IsSpecified) && (!this.Choices.IsSpecified || (EqualityComparer<System.Collections.Generic.IReadOnlyCollection<Discord.Models.IApplicationCommandOptionChoiceModel<long>>>.Default.Equals(this.Choices.Value, other.Choices.Value))) &&
            (this.MinValue.IsSpecified == other.MinValue.IsSpecified) && (!this.MinValue.IsSpecified || (EqualityComparer<long>.Default.Equals(this.MinValue.Value, other.MinValue.Value))) &&
            (this.MaxValue.IsSpecified == other.MaxValue.IsSpecified) && (!this.MaxValue.IsSpecified || (EqualityComparer<long>.Default.Equals(this.MaxValue.Value, other.MaxValue.Value))) &&
            (this.Autocomplete.IsSpecified == other.Autocomplete.IsSpecified) && (!this.Autocomplete.IsSpecified || (EqualityComparer<bool>.Default.Equals(this.Autocomplete.Value, other.Autocomplete.Value))) &&
            EqualityComparer<int>.Default.Equals(this.Type, other.Type) &&
            EqualityComparer<string>.Default.Equals(this.Name, other.Name) &&
            (this.NameLocalizations.IsSpecified == other.NameLocalizations.IsSpecified) && (!this.NameLocalizations.IsSpecified || ((this.NameLocalizations.Value is null == other.NameLocalizations.Value is null) && (this.NameLocalizations.Value is null || (this.NameLocalizations.Value.Count == other.NameLocalizations.Value.Count && this.NameLocalizations.Value.All(kvp => other.NameLocalizations.Value.ContainsKey(kvp.Key) && EqualityComparer<string>.Default.Equals(kvp.Value, other.NameLocalizations.Value[kvp.Key])))))) &&
            EqualityComparer<string>.Default.Equals(this.Description, other.Description) &&
            (this.DescriptionLocalizations.IsSpecified == other.DescriptionLocalizations.IsSpecified) && (!this.DescriptionLocalizations.IsSpecified || ((this.DescriptionLocalizations.Value is null == other.DescriptionLocalizations.Value is null) && (this.DescriptionLocalizations.Value is null || (this.DescriptionLocalizations.Value.Count == other.DescriptionLocalizations.Value.Count && this.DescriptionLocalizations.Value.All(kvp => other.DescriptionLocalizations.Value.ContainsKey(kvp.Key) && EqualityComparer<string>.Default.Equals(kvp.Value, other.DescriptionLocalizations.Value[kvp.Key]))))));
    }
    

    bool IEquatable<Discord.Models.IIntegerApplicationCommandOptionModel>.Equals(Discord.Models.IIntegerApplicationCommandOptionModel? other) => Equals(other);

    bool IEquatable<Discord.Models.IApplicationCommandOptionModel>.Equals(Discord.Models.IApplicationCommandOptionModel? other) => other is Discord.Models.IIntegerApplicationCommandOptionModel self && Equals(self);

    bool Discord.Models.IApplicationCommandOptionModel.Equals(Discord.Models.IApplicationCommandOptionModel? other) => other is Discord.Models.IIntegerApplicationCommandOptionModel self && Equals(self);
}
