namespace Discord.Models;

public interface IRequestGuildMembersPayloadData : IGatewayPayloadData
{
    ulong GuildId { get; }
    Optional<string> Query { get; }
    int Limit { get; }
    Optional<bool> IncludePresences { get; }
    Optional<IReadOnlyCollection<ulong>> UserIds { get; }
    Optional<string> Nonce { get; }
}
