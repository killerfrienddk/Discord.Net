namespace Discord.Models;

[ModelEquality]
public partial interface IPollModel : IModel
{
    IPollMediaModel Question { get; }
    IReadOnlyCollection<IPollAnswerModel> Answers { get; }
    DateTimeOffset? Expiry { get; }
    bool AllowMultiselect { get; }
    int LayoutType { get; }
    Optional<IPollResultModel> Results { get; }
}