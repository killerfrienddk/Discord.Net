using System.Text.Json.Serialization;

namespace Discord.Models.Json;

public sealed partial class GuildScheduledEventPayload : IExtendedModel<Discord.Models.Json.GuildScheduledEvent>
{
    Discord.Models.Json.GuildScheduledEvent IExtendedModel<Discord.Models.Json.GuildScheduledEvent>.ExtendedValue => Event;

    ulong Discord.Models.IGuildScheduledEventModel.GuildId => (Event as Discord.Models.IGuildScheduledEventModel).GuildId;

    ulong? Discord.Models.IGuildScheduledEventModel.ChannelId => (Event as Discord.Models.IGuildScheduledEventModel).ChannelId;

    ulong Discord.Models.IGuildScheduledEventModel.CreatorId => (Event as Discord.Models.IGuildScheduledEventModel).CreatorId;

    string Discord.Models.IGuildScheduledEventModel.Name => (Event as Discord.Models.IGuildScheduledEventModel).Name;

    string? Discord.Models.IGuildScheduledEventModel.Description => (Event as Discord.Models.IGuildScheduledEventModel).Description;

    System.DateTimeOffset Discord.Models.IGuildScheduledEventModel.ScheduledStartTime => (Event as Discord.Models.IGuildScheduledEventModel).ScheduledStartTime;

    System.DateTimeOffset? Discord.Models.IGuildScheduledEventModel.ScheduledEndTime => (Event as Discord.Models.IGuildScheduledEventModel).ScheduledEndTime;

    int Discord.Models.IGuildScheduledEventModel.PrivacyLevel => (Event as Discord.Models.IGuildScheduledEventModel).PrivacyLevel;

    int Discord.Models.IGuildScheduledEventModel.Status => (Event as Discord.Models.IGuildScheduledEventModel).Status;

    int Discord.Models.IGuildScheduledEventModel.EntityType => (Event as Discord.Models.IGuildScheduledEventModel).EntityType;

    ulong? Discord.Models.IGuildScheduledEventModel.EntityId => (Event as Discord.Models.IGuildScheduledEventModel).EntityId;

    int? Discord.Models.IGuildScheduledEventModel.UserCount => (Event as Discord.Models.IGuildScheduledEventModel).UserCount;

    string? Discord.Models.IGuildScheduledEventModel.Image => (Event as Discord.Models.IGuildScheduledEventModel).Image;

    string? Discord.Models.IGuildScheduledEventModel.Location => (Event as Discord.Models.IGuildScheduledEventModel).Location;

    ulong Discord.Models.IEntityModel<ulong>.Id => (Event as Discord.Models.IEntityModel<ulong>).Id;
}