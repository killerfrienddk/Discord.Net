namespace Discord.Models;

[ModelEquality]
public partial interface IEmbedFieldModel : IModel
{
    string Name { get; }
    string Value { get; }
    Optional<bool> Inline { get; }
}