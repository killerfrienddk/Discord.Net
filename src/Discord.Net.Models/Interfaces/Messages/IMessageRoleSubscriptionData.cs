namespace Discord.Models;

[ModelEquality]
public partial interface IMessageRoleSubscriptionData : IModel
{
    ulong RoleSubscriptionListingId { get; }
    string TierName { get; }
    int TotalMonthsSubscribed { get; }
    bool IsRenewal { get; }
}