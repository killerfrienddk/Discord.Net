namespace Discord.Models;

[ModelEquality, HasPartialVariant]
public partial interface IThreadChannelModel : IGuildChannelModel
{
    [SourceOfTruth]
    new ulong ParentId { get; }
    int MemberCount { get; }
    Optional<int> MessageCount { get; }
    Optional<ulong[]> AppliedTags { get; }
    ulong OwnerId { get; }
    Optional<int> RatelimitPerUser { get; }
    bool IsNsfw { get; }
    string? Topic { get; }
    
    IThreadMetadataModel Metadata { get; }
}
