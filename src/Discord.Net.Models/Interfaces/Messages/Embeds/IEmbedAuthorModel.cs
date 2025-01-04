namespace Discord.Models;

[ModelEquality]
public partial interface IEmbedAuthorModel : IModel
{
    string Name { get; }
    Optional<string> Url { get; }
    Optional<string> IconUrl { get; }
    Optional<string> ProxyIconUrl { get; }
}