namespace Discord.Models;

public interface IGuildStickersUpdatedPayloadData : IGatewayPayloadData
{
    ulong GuildId { get; }
    IReadOnlyCollection<IGuildStickerModel> Stickers { get; }
}
