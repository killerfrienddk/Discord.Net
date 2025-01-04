namespace Discord.Models;

[ModelEquality]
public partial interface IActivityTimestampsModel : IModel
{
    Optional<DateTimeOffset> Start { get; set; }
    Optional<DateTimeOffset> End { get; set; }
}