namespace Discord.Models;

[ModelEquality]
public partial interface IActivityButtonModel : IModel
{
    string Label { get; }
    string Url { get; }
}