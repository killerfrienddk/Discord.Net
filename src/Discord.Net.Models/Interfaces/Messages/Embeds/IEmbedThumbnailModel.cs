namespace Discord.Models;

[ModelEquality]
public partial interface IEmbedThumbnailModel : IModel
{
    string Url { get; }
    Optional<string> ProxyUrl { get; }
    Optional<int> Height { get; }
    Optional<int> Width { get; }
}