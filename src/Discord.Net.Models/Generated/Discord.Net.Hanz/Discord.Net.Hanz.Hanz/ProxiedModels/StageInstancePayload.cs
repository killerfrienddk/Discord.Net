using System.Text.Json.Serialization;

namespace Discord.Models.Json;

public sealed partial class StageInstancePayload : IExtendedModel<Discord.Models.Json.StageInstance>
{
    Discord.Models.Json.StageInstance IExtendedModel<Discord.Models.Json.StageInstance>.ExtendedValue => StageInstance;

    ulong Discord.Models.IStageInstanceModel.GuildId => (StageInstance as Discord.Models.IStageInstanceModel).GuildId;

    ulong Discord.Models.IStageInstanceModel.ChannelId => (StageInstance as Discord.Models.IStageInstanceModel).ChannelId;

    string Discord.Models.IStageInstanceModel.Topic => (StageInstance as Discord.Models.IStageInstanceModel).Topic;

    int Discord.Models.IStageInstanceModel.PrivacyLevel => (StageInstance as Discord.Models.IStageInstanceModel).PrivacyLevel;

    bool Discord.Models.IStageInstanceModel.DiscoverableDisabled => (StageInstance as Discord.Models.IStageInstanceModel).DiscoverableDisabled;

    ulong? Discord.Models.IStageInstanceModel.EventId => (StageInstance as Discord.Models.IStageInstanceModel).EventId;

    ulong Discord.Models.IEntityModel<ulong>.Id => (StageInstance as Discord.Models.IEntityModel<ulong>).Id;
}