namespace Discord.Models;

[ModelEquality]
public partial interface IEmbedFooterModel : IModel
{
    string Text { get; }
    Optional<string> IconUrl { get; }
    Optional<string> ProxyIconUrl { get; }
}