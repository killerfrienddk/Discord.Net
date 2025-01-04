using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IAttachmentApplicationCommandOptionModel : 
    IEquatable<Discord.Models.IAttachmentApplicationCommandOptionModel>
{
    new bool Equals(Discord.Models.IAttachmentApplicationCommandOptionModel? other)
    {
        if(other is null) return false;
        
        return
            (this.IsRequired.IsSpecified == other.IsRequired.IsSpecified) && (!this.IsRequired.IsSpecified || (EqualityComparer<bool>.Default.Equals(this.IsRequired.Value, other.IsRequired.Value))) &&
            EqualityComparer<int>.Default.Equals(this.Type, other.Type) &&
            EqualityComparer<string>.Default.Equals(this.Name, other.Name) &&
            (this.NameLocalizations.IsSpecified == other.NameLocalizations.IsSpecified) && (!this.NameLocalizations.IsSpecified || ((this.NameLocalizations.Value is null == other.NameLocalizations.Value is null) && (this.NameLocalizations.Value is null || (this.NameLocalizations.Value.Count == other.NameLocalizations.Value.Count && this.NameLocalizations.Value.All(kvp => other.NameLocalizations.Value.ContainsKey(kvp.Key) && EqualityComparer<string>.Default.Equals(kvp.Value, other.NameLocalizations.Value[kvp.Key])))))) &&
            EqualityComparer<string>.Default.Equals(this.Description, other.Description) &&
            (this.DescriptionLocalizations.IsSpecified == other.DescriptionLocalizations.IsSpecified) && (!this.DescriptionLocalizations.IsSpecified || ((this.DescriptionLocalizations.Value is null == other.DescriptionLocalizations.Value is null) && (this.DescriptionLocalizations.Value is null || (this.DescriptionLocalizations.Value.Count == other.DescriptionLocalizations.Value.Count && this.DescriptionLocalizations.Value.All(kvp => other.DescriptionLocalizations.Value.ContainsKey(kvp.Key) && EqualityComparer<string>.Default.Equals(kvp.Value, other.DescriptionLocalizations.Value[kvp.Key]))))));
    }
    

    bool IEquatable<Discord.Models.IAttachmentApplicationCommandOptionModel>.Equals(Discord.Models.IAttachmentApplicationCommandOptionModel? other) => Equals(other);

    bool IEquatable<Discord.Models.IApplicationCommandOptionModel>.Equals(Discord.Models.IApplicationCommandOptionModel? other) => other is Discord.Models.IAttachmentApplicationCommandOptionModel self && Equals(self);

    bool Discord.Models.IApplicationCommandOptionModel.Equals(Discord.Models.IApplicationCommandOptionModel? other) => other is Discord.Models.IAttachmentApplicationCommandOptionModel self && Equals(self);
}
