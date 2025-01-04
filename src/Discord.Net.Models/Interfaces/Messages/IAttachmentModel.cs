namespace Discord.Models;

[ModelEquality]
public partial interface IAttachmentModel : IEntityModel<ulong>
{
    string Filename { get; }
    Optional<string> Title { get; }
    Optional<string> Description { get; }
    Optional<string> ContentType { get; }
    int Size { get; }
    string Url { get; }
    string ProxyUrl { get; }
    Optional<int?> Height { get; }
    Optional<int?> Width { get; }
    Optional<bool> Ephemeral { get; }
    Optional<TimeSpan> Duration { get; }
    Optional<string> Waveform { get; }
    Optional<int> Flags { get; }
}
