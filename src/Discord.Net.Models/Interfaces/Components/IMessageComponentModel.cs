namespace Discord.Models;

[ModelEquality]
public partial interface IMessageComponentModel : IModel
{
    int Type { get; }
}
