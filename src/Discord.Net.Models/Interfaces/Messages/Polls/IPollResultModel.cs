namespace Discord.Models;

[ModelEquality]
public partial interface IPollResultModel : IModel
{
    bool IsFinalized { get; }
    
    IReadOnlyCollection<IPollAnswerCountModel> AnswerCounts { get; }
}