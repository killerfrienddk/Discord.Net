using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IApplicationCommandModel : 
    IEquatable<Discord.Models.IApplicationCommandModel>
{
    new bool Equals(Discord.Models.IApplicationCommandModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<int?>.Default.Equals(this.Type, other.Type) &&
            EqualityComparer<ulong>.Default.Equals(this.ApplicationId, other.ApplicationId) &&
            (this.GuildId.IsSpecified == other.GuildId.IsSpecified) && (!this.GuildId.IsSpecified || (EqualityComparer<ulong>.Default.Equals(this.GuildId.Value, other.GuildId.Value))) &&
            EqualityComparer<string>.Default.Equals(this.Name, other.Name) &&
            (this.NameLocalization.IsSpecified == other.NameLocalization.IsSpecified) && (!this.NameLocalization.IsSpecified || ((this.NameLocalization.Value is null == other.NameLocalization.Value is null) && (this.NameLocalization.Value is null || (this.NameLocalization.Value.Count == other.NameLocalization.Value.Count && this.NameLocalization.Value.All(kvp => other.NameLocalization.Value.ContainsKey(kvp.Key) && EqualityComparer<string>.Default.Equals(kvp.Value, other.NameLocalization.Value[kvp.Key])))))) &&
            EqualityComparer<string>.Default.Equals(this.Description, other.Description) &&
            (this.DescriptionLocalization.IsSpecified == other.DescriptionLocalization.IsSpecified) && (!this.DescriptionLocalization.IsSpecified || ((this.DescriptionLocalization.Value is null == other.DescriptionLocalization.Value is null) && (this.DescriptionLocalization.Value is null || (this.DescriptionLocalization.Value.Count == other.DescriptionLocalization.Value.Count && this.DescriptionLocalization.Value.All(kvp => other.DescriptionLocalization.Value.ContainsKey(kvp.Key) && EqualityComparer<string>.Default.Equals(kvp.Value, other.DescriptionLocalization.Value[kvp.Key])))))) &&
            EqualityComparer<string?>.Default.Equals(this.DefaultMemberPermissions, other.DefaultMemberPermissions) &&
            (this.IsNsfw.IsSpecified == other.IsNsfw.IsSpecified) && (!this.IsNsfw.IsSpecified || (EqualityComparer<bool>.Default.Equals(this.IsNsfw.Value, other.IsNsfw.Value))) &&
            (this.IntegrationTypes.IsSpecified == other.IntegrationTypes.IsSpecified) && (!this.IntegrationTypes.IsSpecified || ((this.IntegrationTypes.Value is null == other.IntegrationTypes.Value is null) && (this.IntegrationTypes.Value is null || this.IntegrationTypes.Value.SequenceEqual(other.IntegrationTypes.Value!)))) &&
            (this.Contexts.IsSpecified == other.Contexts.IsSpecified) && (!this.Contexts.IsSpecified || ((this.Contexts.Value is null == other.Contexts.Value is null) && (this.Contexts.Value is null || this.Contexts.Value.SequenceEqual(other.Contexts.Value!)))) &&
            EqualityComparer<ulong>.Default.Equals(this.Version, other.Version);
    }
    

    bool IEquatable<Discord.Models.IApplicationCommandModel>.Equals(Discord.Models.IApplicationCommandModel? other) => Equals(other);
}
