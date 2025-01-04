using System.Text.Json.Serialization;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IPartialThreadChannelModel : 
    IPartialModel,
    IEntityModel<ulong>,
    Discord.Models.IPartialGuildChannelModel,
    Discord.Models.IPartialChannelModel
{
    Discord.Optional<ulong> ParentId { get; }

    Discord.Optional<int> MemberCount { get; }

    Discord.Optional<int> MessageCount { get; }

    Discord.Optional<ulong[]> AppliedTags { get; }

    Discord.Optional<ulong> OwnerId { get; }

    Discord.Optional<int> RatelimitPerUser { get; }

    Discord.Optional<bool> IsNsfw { get; }

    Discord.Optional<string?> Topic { get; }

    Discord.Optional<Discord.Models.IThreadMetadataModel> Metadata { get; }

    Type IPartialModel.UnderlyingModelType => typeof(Discord.Models.IThreadChannelModel);
}
