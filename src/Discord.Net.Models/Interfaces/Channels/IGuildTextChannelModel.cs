namespace Discord.Models;

[ModelEquality, HasPartialVariant]
public partial interface IGuildTextChannelModel : IThreadableChannelModel
{
    Optional<int> RatelimitPerUser { get; }
    bool IsNsfw { get; }
    string? Topic { get; }
}
