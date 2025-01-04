using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IAutoModerationRuleModel : 
    IEquatable<Discord.Models.IAutoModerationRuleModel>
{
    new bool Equals(Discord.Models.IAutoModerationRuleModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<ulong>.Default.Equals(this.GuildId, other.GuildId) &&
            EqualityComparer<string>.Default.Equals(this.Name, other.Name) &&
            EqualityComparer<ulong>.Default.Equals(this.CreatorId, other.CreatorId) &&
            EqualityComparer<int>.Default.Equals(this.EventType, other.EventType) &&
            EqualityComparer<int>.Default.Equals(this.TriggerType, other.TriggerType) &&
            EqualityComparer<Discord.Models.ITriggerMetadataModel>.Default.Equals(this.TriggerMetadata, other.TriggerMetadata) &&
            EqualityComparer<System.Collections.Generic.IReadOnlyCollection<Discord.Models.IAutoModerationActionModel>>.Default.Equals(this.Actions, other.Actions) &&
            EqualityComparer<bool>.Default.Equals(this.IsEnabled, other.IsEnabled) &&
            (this.ExemptRoles is null == other.ExemptRoles is null) && (this.ExemptRoles is null || this.ExemptRoles.SequenceEqual(other.ExemptRoles!)) &&
            (this.ExemptChannels is null == other.ExemptChannels is null) && (this.ExemptChannels is null || this.ExemptChannels.SequenceEqual(other.ExemptChannels!));
    }
    

    bool IEquatable<Discord.Models.IAutoModerationRuleModel>.Equals(Discord.Models.IAutoModerationRuleModel? other) => Equals(other);
}
