using System.Text.Json.Serialization;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IPartialVoiceStateModel : 
    IPartialModel
{
    Discord.Optional<ulong> GuildId { get; }

    Discord.Optional<ulong?> ChannelId { get; }

    Discord.Optional<ulong> UserId { get; }

    Discord.Optional<Discord.Models.ModelOrId<Discord.Models.IMemberModel, ulong>> Member { get; }

    Discord.Optional<string> SessionId { get; }

    Discord.Optional<bool> IsDeafened { get; }

    Discord.Optional<bool> IsMuted { get; }

    Discord.Optional<bool> IsSelfDeafened { get; }

    Discord.Optional<bool> IsSelfMuted { get; }

    Discord.Optional<bool> IsSelfStreaming { get; }

    Discord.Optional<bool> IsSelfVideo { get; }

    Discord.Optional<bool> IsSuppressed { get; }

    Discord.Optional<System.DateTimeOffset?> RequestToSpeakTimestamp { get; }

    Type IPartialModel.UnderlyingModelType => typeof(Discord.Models.IVoiceStateModel);
}
