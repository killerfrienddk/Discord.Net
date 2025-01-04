using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IGuildScheduledEventRecurrenceRuleModel : 
    IEquatable<Discord.Models.IGuildScheduledEventRecurrenceRuleModel>
{
    new bool Equals(Discord.Models.IGuildScheduledEventRecurrenceRuleModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<System.DateTimeOffset>.Default.Equals(this.Start, other.Start) &&
            EqualityComparer<System.DateTimeOffset?>.Default.Equals(this.End, other.End) &&
            EqualityComparer<int>.Default.Equals(this.Frequency, other.Frequency) &&
            EqualityComparer<int>.Default.Equals(this.Interval, other.Interval) &&
            (this.ByWeekday is null == other.ByWeekday is null) && (this.ByWeekday is null || this.ByWeekday.SequenceEqual(other.ByWeekday!)) &&
            (this.ByNWeekday is null == other.ByNWeekday is null) && (this.ByNWeekday is null || this.ByNWeekday.SequenceEqual(other.ByNWeekday!)) &&
            (this.ByMonth is null == other.ByMonth is null) && (this.ByMonth is null || this.ByMonth.SequenceEqual(other.ByMonth!)) &&
            (this.ByMonthDay is null == other.ByMonthDay is null) && (this.ByMonthDay is null || this.ByMonthDay.SequenceEqual(other.ByMonthDay!)) &&
            (this.ByYearDay is null == other.ByYearDay is null) && (this.ByYearDay is null || this.ByYearDay.SequenceEqual(other.ByYearDay!)) &&
            EqualityComparer<int?>.Default.Equals(this.Count, other.Count);
    }
    

    bool IEquatable<Discord.Models.IGuildScheduledEventRecurrenceRuleModel>.Equals(Discord.Models.IGuildScheduledEventRecurrenceRuleModel? other) => Equals(other);
}
