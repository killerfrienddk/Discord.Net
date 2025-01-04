using System.Text.Json.Serialization;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IPartialGuildChannelModel : 
    IPartialModel,
    IEntityModel<ulong>,
    Discord.Models.IPartialChannelModel
{
    Discord.Optional<string> Name { get; }

    Discord.Optional<ulong> GuildId { get; }

    Discord.Optional<ulong?> ParentId { get; }

    Discord.Optional<int> Position { get; }

    Discord.Optional<System.Collections.Generic.IReadOnlyCollection<Discord.Models.IOverwriteModel>> PermissionOverwrites { get; }

    Discord.Optional<int> Flags { get; }

    Type IPartialModel.UnderlyingModelType => typeof(Discord.Models.IGuildChannelModel);
}
