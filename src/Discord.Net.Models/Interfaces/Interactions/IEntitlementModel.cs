namespace Discord.Models;

[ModelEquality]
public partial interface IEntitlementModel : IEntityModel<ulong>
{
    ulong SkuId { get; }
    ulong ApplicationId { get; }
    Optional<ulong> UserId { get; }
    int Type { get; }
    bool IsDeleted { get; }
    DateTimeOffset? StartsAt { get; }
    DateTimeOffset? EndsAt { get; }
    Optional<ulong> GuildId { get; }
    Optional<bool> Consumed { get; }
}
