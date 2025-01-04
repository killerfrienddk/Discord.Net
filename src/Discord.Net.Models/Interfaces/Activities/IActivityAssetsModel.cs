namespace Discord.Models;

[ModelEquality]
public partial interface IActivityAssetsModel : IModel
{
    Optional<string> LargeImage { get; }
    Optional<string> LargeText { get; }
    Optional<string> SmallImage { get; }
    Optional<string> SmallText { get; }
}