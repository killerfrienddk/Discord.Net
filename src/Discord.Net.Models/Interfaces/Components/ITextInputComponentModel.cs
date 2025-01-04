namespace Discord.Models;

[ModelEquality]
public partial interface ITextInputComponentModel : IMessageComponentModel
{
    string CustomId { get; }
    int Style { get; }
    string Label { get; }
    Optional<int> MinLength { get; }
    Optional<int> MaxLength { get; }
    Optional<bool> IsRequired { get; }
    Optional<string> Value { get; }
    Optional<string> Placeholder { get; }
}
