namespace Discord.Models;

[ModelEquality]
public partial interface IActionRowModel : IMessageComponentModel
{
    IReadOnlyCollection<IMessageComponentModel> Components { get; }
}
