namespace Discord.Models;

[ModelEquality]
public partial interface ISelectMenuComponentModel : IMessageComponentModel
{
    string CustomId { get; }
    Optional<IReadOnlyCollection<ISelectMenuOptionModel>> Options { get; }
    Optional<int[]> ChannelTypes { get; }
    Optional<string> Placeholder { get; }
    Optional<IReadOnlyCollection<ISelectMenuDefaultValueModel>> DefaultValues { get; }
    Optional<int> MinValues { get; }
    Optional<int> MaxValues { get; }
    Optional<bool> IsDisabled { get; }
}
