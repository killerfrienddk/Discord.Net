using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface ITextInputComponentModel : 
    IEquatable<Discord.Models.ITextInputComponentModel>
{
    new bool Equals(Discord.Models.ITextInputComponentModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<string>.Default.Equals(this.CustomId, other.CustomId) &&
            EqualityComparer<int>.Default.Equals(this.Style, other.Style) &&
            EqualityComparer<string>.Default.Equals(this.Label, other.Label) &&
            (this.MinLength.IsSpecified == other.MinLength.IsSpecified) && (!this.MinLength.IsSpecified || (EqualityComparer<int>.Default.Equals(this.MinLength.Value, other.MinLength.Value))) &&
            (this.MaxLength.IsSpecified == other.MaxLength.IsSpecified) && (!this.MaxLength.IsSpecified || (EqualityComparer<int>.Default.Equals(this.MaxLength.Value, other.MaxLength.Value))) &&
            (this.IsRequired.IsSpecified == other.IsRequired.IsSpecified) && (!this.IsRequired.IsSpecified || (EqualityComparer<bool>.Default.Equals(this.IsRequired.Value, other.IsRequired.Value))) &&
            (this.Value.IsSpecified == other.Value.IsSpecified) && (!this.Value.IsSpecified || (EqualityComparer<string>.Default.Equals(this.Value.Value, other.Value.Value))) &&
            (this.Placeholder.IsSpecified == other.Placeholder.IsSpecified) && (!this.Placeholder.IsSpecified || (EqualityComparer<string>.Default.Equals(this.Placeholder.Value, other.Placeholder.Value))) &&
            EqualityComparer<int>.Default.Equals(this.Type, other.Type);
    }
    

    bool IEquatable<Discord.Models.ITextInputComponentModel>.Equals(Discord.Models.ITextInputComponentModel? other) => Equals(other);

    bool IEquatable<Discord.Models.IMessageComponentModel>.Equals(Discord.Models.IMessageComponentModel? other) => other is Discord.Models.ITextInputComponentModel self && Equals(self);

    bool Discord.Models.IMessageComponentModel.Equals(Discord.Models.IMessageComponentModel? other) => other is Discord.Models.ITextInputComponentModel self && Equals(self);
}
