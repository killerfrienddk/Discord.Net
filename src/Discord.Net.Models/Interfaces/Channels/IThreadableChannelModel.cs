namespace Discord.Models;

[ModelEquality]
public partial interface IThreadableChannelModel : IGuildChannelModel
{
    int DefaultAutoArchiveDuration { get; }
    Optional<int> DefaultThreadRateLimitPerUser { get; }
}
