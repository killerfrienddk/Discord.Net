namespace Discord.Models.Dispatch;

public interface IReadyPayloadData : IGatewayPayloadData
{
    int Version { get; }
    ISelfUserModel User { get; }
    IReadOnlyCollection<IUnavailableGuild> Guilds { get; }
    string SessionId { get; }
    string ResumeGatewayUrl { get; }
    Optional<int[]> Shard { get; }
    IPartialApplicationModel Application { get; }
}
