namespace Discord.Models;

public interface IRoleTagsModel
{
    Optional<ulong> BotId { get; }
    Optional<ulong> IntegrationId { get; }
    Optional<ulong> SubscriptionListingId { get; }
    bool IsPremiumSubscriberRole { get; }
    bool IsAvailableForPurchase { get; }
    bool IsGuildConnection { get; }
}