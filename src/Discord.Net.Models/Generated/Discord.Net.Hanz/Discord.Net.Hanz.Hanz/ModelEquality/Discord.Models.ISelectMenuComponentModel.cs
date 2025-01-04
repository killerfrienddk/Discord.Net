using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface ISelectMenuComponentModel : 
    IEquatable<Discord.Models.ISelectMenuComponentModel>
{
    new bool Equals(Discord.Models.ISelectMenuComponentModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<string>.Default.Equals(this.CustomId, other.CustomId) &&
            (this.Options.IsSpecified == other.Options.IsSpecified) && (!this.Options.IsSpecified || (EqualityComparer<System.Collections.Generic.IReadOnlyCollection<Discord.Models.ISelectMenuOptionModel>>.Default.Equals(this.Options.Value, other.Options.Value))) &&
            (this.ChannelTypes.IsSpecified == other.ChannelTypes.IsSpecified) && (!this.ChannelTypes.IsSpecified || ((this.ChannelTypes.Value is null == other.ChannelTypes.Value is null) && (this.ChannelTypes.Value is null || this.ChannelTypes.Value.SequenceEqual(other.ChannelTypes.Value!)))) &&
            (this.Placeholder.IsSpecified == other.Placeholder.IsSpecified) && (!this.Placeholder.IsSpecified || (EqualityComparer<string>.Default.Equals(this.Placeholder.Value, other.Placeholder.Value))) &&
            (this.DefaultValues.IsSpecified == other.DefaultValues.IsSpecified) && (!this.DefaultValues.IsSpecified || (EqualityComparer<System.Collections.Generic.IReadOnlyCollection<Discord.Models.ISelectMenuDefaultValueModel>>.Default.Equals(this.DefaultValues.Value, other.DefaultValues.Value))) &&
            (this.MinValues.IsSpecified == other.MinValues.IsSpecified) && (!this.MinValues.IsSpecified || (EqualityComparer<int>.Default.Equals(this.MinValues.Value, other.MinValues.Value))) &&
            (this.MaxValues.IsSpecified == other.MaxValues.IsSpecified) && (!this.MaxValues.IsSpecified || (EqualityComparer<int>.Default.Equals(this.MaxValues.Value, other.MaxValues.Value))) &&
            (this.IsDisabled.IsSpecified == other.IsDisabled.IsSpecified) && (!this.IsDisabled.IsSpecified || (EqualityComparer<bool>.Default.Equals(this.IsDisabled.Value, other.IsDisabled.Value))) &&
            EqualityComparer<int>.Default.Equals(this.Type, other.Type);
    }
    

    bool IEquatable<Discord.Models.ISelectMenuComponentModel>.Equals(Discord.Models.ISelectMenuComponentModel? other) => Equals(other);

    bool IEquatable<Discord.Models.IMessageComponentModel>.Equals(Discord.Models.IMessageComponentModel? other) => other is Discord.Models.ISelectMenuComponentModel self && Equals(self);

    bool Discord.Models.IMessageComponentModel.Equals(Discord.Models.IMessageComponentModel? other) => other is Discord.Models.ISelectMenuComponentModel self && Equals(self);
}
