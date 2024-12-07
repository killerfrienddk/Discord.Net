using System.Text.Json.Serialization;

namespace Discord.Models.Json;

public sealed partial class AutoModerationRulePayload : IExtendedModel<Discord.Models.Json.AutoModerationRule>
{
    Discord.Models.Json.AutoModerationRule IExtendedModel<Discord.Models.Json.AutoModerationRule>.ExtendedValue => AutoModerationRule;

    ulong Discord.Models.IAutoModerationRuleModel.GuildId => (AutoModerationRule as Discord.Models.IAutoModerationRuleModel).GuildId;

    string Discord.Models.IAutoModerationRuleModel.Name => (AutoModerationRule as Discord.Models.IAutoModerationRuleModel).Name;

    ulong Discord.Models.IAutoModerationRuleModel.CreatorId => (AutoModerationRule as Discord.Models.IAutoModerationRuleModel).CreatorId;

    int Discord.Models.IAutoModerationRuleModel.EventType => (AutoModerationRule as Discord.Models.IAutoModerationRuleModel).EventType;

    int Discord.Models.IAutoModerationRuleModel.TriggerType => (AutoModerationRule as Discord.Models.IAutoModerationRuleModel).TriggerType;

    Discord.Models.ITriggerMetadataModel? Discord.Models.IAutoModerationRuleModel.TriggerMetadata => (AutoModerationRule as Discord.Models.IAutoModerationRuleModel).TriggerMetadata;

    System.Collections.Generic.IEnumerable<Discord.Models.IAutoModerationActionModel> Discord.Models.IAutoModerationRuleModel.Actions => (AutoModerationRule as Discord.Models.IAutoModerationRuleModel).Actions;

    bool Discord.Models.IAutoModerationRuleModel.IsEnabled => (AutoModerationRule as Discord.Models.IAutoModerationRuleModel).IsEnabled;

    ulong[] Discord.Models.IAutoModerationRuleModel.ExemptRoles => (AutoModerationRule as Discord.Models.IAutoModerationRuleModel).ExemptRoles;

    ulong[] Discord.Models.IAutoModerationRuleModel.ExemptChannels => (AutoModerationRule as Discord.Models.IAutoModerationRuleModel).ExemptChannels;

    ulong Discord.Models.IEntityModel<ulong>.Id => (AutoModerationRule as Discord.Models.IEntityModel<ulong>).Id;
}