namespace Discord.Models;

public interface IGuildEmotesUpdatedPayloadData : IGatewayPayloadData
{
    ulong GuildId { get; }
    IReadOnlyCollection<ICustomEmoteModel> Emotes { get; }
}
