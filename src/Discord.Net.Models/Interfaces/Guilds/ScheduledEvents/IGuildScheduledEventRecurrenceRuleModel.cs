namespace Discord.Models;

[ModelEquality]
public partial interface IGuildScheduledEventRecurrenceRuleModel : IModel
{
    DateTimeOffset Start { get; }
    DateTimeOffset? End { get; }
    int Frequency { get; }
    int Interval { get; }
    
    int[]? ByWeekday { get; }
    int[]? ByNWeekday { get; }
    int[]? ByMonth { get; }
    int[]? ByMonthDay { get; }
    int[]? ByYearDay { get; }
    int? Count { get; }
}