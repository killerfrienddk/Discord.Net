using System.Text.Json.Serialization;

namespace Discord.Models.Json;

public sealed partial class ThreadCreated : IExtendedModel<Discord.Models.Json.ThreadChannelBase>
{
    Discord.Models.Json.ThreadChannelBase IExtendedModel<Discord.Models.Json.ThreadChannelBase>.ExtendedValue => Thread;

    ulong Discord.Models.IThreadChannelModel.ParentId => (Thread as Discord.Models.IThreadChannelModel).ParentId;

    bool Discord.Models.IThreadChannelModel.IsArchived => (Thread as Discord.Models.IThreadChannelModel).IsArchived;

    int Discord.Models.IThreadChannelModel.AutoArchiveDuration => (Thread as Discord.Models.IThreadChannelModel).AutoArchiveDuration;

    System.DateTimeOffset Discord.Models.IThreadChannelModel.ArchiveTimestamp => (Thread as Discord.Models.IThreadChannelModel).ArchiveTimestamp;

    bool Discord.Models.IThreadChannelModel.IsLocked => (Thread as Discord.Models.IThreadChannelModel).IsLocked;

    int Discord.Models.IThreadChannelModel.MemberCount => (Thread as Discord.Models.IThreadChannelModel).MemberCount;

    int Discord.Models.IThreadChannelModel.MessageCount => (Thread as Discord.Models.IThreadChannelModel).MessageCount;

    bool? Discord.Models.IThreadChannelModel.IsInvitable => (Thread as Discord.Models.IThreadChannelModel).IsInvitable;

    bool Discord.Models.IThreadChannelModel.HasJoined => (Thread as Discord.Models.IThreadChannelModel).HasJoined;

    System.DateTimeOffset? Discord.Models.IThreadChannelModel.CreatedAt => (Thread as Discord.Models.IThreadChannelModel).CreatedAt;

    ulong[] Discord.Models.IThreadChannelModel.AppliedTags => (Thread as Discord.Models.IThreadChannelModel).AppliedTags;

    ulong Discord.Models.IThreadChannelModel.OwnerId => (Thread as Discord.Models.IThreadChannelModel).OwnerId;

    int Discord.Models.IThreadChannelModel.RatelimitPerUser => (Thread as Discord.Models.IThreadChannelModel).RatelimitPerUser;

    bool Discord.Models.IThreadChannelModel.IsNsfw => (Thread as Discord.Models.IThreadChannelModel).IsNsfw;

    string? Discord.Models.IThreadChannelModel.Topic => (Thread as Discord.Models.IThreadChannelModel).Topic;

    string Discord.Models.IGuildChannelModel.Name => (Thread as Discord.Models.IGuildChannelModel).Name;

    ulong Discord.Models.IGuildChannelModel.GuildId => (Thread as Discord.Models.IGuildChannelModel).GuildId;

    ulong? Discord.Models.IGuildChannelModel.ParentId => (Thread as Discord.Models.IGuildChannelModel).ParentId;

    int Discord.Models.IGuildChannelModel.Position => (Thread as Discord.Models.IGuildChannelModel).Position;

    System.Collections.Generic.IEnumerable<Discord.Models.IOverwriteModel> Discord.Models.IGuildChannelModel.Permissions => (Thread as Discord.Models.IGuildChannelModel).Permissions;

    int? Discord.Models.IGuildChannelModel.Flags => (Thread as Discord.Models.IGuildChannelModel).Flags;

    uint Discord.Models.IChannelModel.Type => (Thread as Discord.Models.IChannelModel).Type;

    ulong Discord.Models.IEntityModel<ulong>.Id => (Thread as Discord.Models.IEntityModel<ulong>).Id;
}