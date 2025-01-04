namespace Discord.Models;

public interface IGuildMembersChunkPayloadData : IGatewayPayloadData
{
    ulong GuildId { get; }
    IReadOnlyCollection<IMemberModel> Members { get; }
    int ChunkIndex { get; }
    int ChunkCount { get; }
    Optional<IReadOnlyCollection<ulong>> NotFound { get; }
    Optional<IReadOnlyCollection<IPresenceModel>> Presences { get; }
    Optional<string> Nonce { get; }
}
