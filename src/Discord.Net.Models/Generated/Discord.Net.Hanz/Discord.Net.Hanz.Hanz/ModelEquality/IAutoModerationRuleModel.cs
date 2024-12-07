

namespace Discord.Models;

public partial interface IAutoModerationRuleModel : IEquatable<IAutoModerationRuleModel>
{
    new bool Equals(Discord.Models.IAutoModerationRuleModel? other)
    {
        if (other is null)
            return false;
        return this.GuildId.Equals(this.GuildId) && this.Name.Equals(this.Name) && this.CreatorId.Equals(this.CreatorId) && this.EventType.Equals(this.EventType) && this.TriggerType.Equals(this.TriggerType) && (this.TriggerMetadata?.Equals(this.TriggerMetadata) ?? this.TriggerMetadata is not null) && this.Actions.Equals(this.Actions) && this.IsEnabled.Equals(this.IsEnabled) && this.ExemptRoles.Equals(this.ExemptRoles) && this.ExemptChannels.Equals(this.ExemptChannels);
    }

    bool IEquatable<IAutoModerationRuleModel>.Equals(IAutoModerationRuleModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IAutoModerationRuleModel otherThis && Equals(otherThis);
}