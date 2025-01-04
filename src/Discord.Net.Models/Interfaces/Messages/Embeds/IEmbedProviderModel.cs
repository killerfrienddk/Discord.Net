namespace Discord.Models;

[ModelEquality]
public partial interface IEmbedProviderModel : IModel
{
    Optional<string> Name { get; }
    Optional<string> Url { get; }
}