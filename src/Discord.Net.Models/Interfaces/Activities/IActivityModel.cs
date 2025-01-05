namespace Discord.Models;

/// <summary>
/// https://discord.com/developers/docs/events/gateway-events#activity-object
/// </summary>
[ModelEquality]
public partial interface IActivityModel : IModel
{
    string Name { get; }
    int Type { get; }
    Optional<string?> Url { get; }
    DateTimeOffset CreatedAt { get; }
    Optional<IActivityTimestampsModel> Timestamps { get; }
    Optional<ulong> ApplicationId { get; }
    Optional<string?> Details { get; }
    Optional<string?> State { get; }
    Optional<DiscordEmojiId?> Emoji { get; }
    Optional<IActivityPartyModel> Party { get; }
    Optional<IActivityAssetsModel> Assets { get; }
    Optional<IActivitySecretsModel> Secrets { get; }
    Optional<bool> IsInstance { get; }
    Optional<int> Flags { get; }
    Optional<IReadOnlyCollection<IActivityButtonModel>> Buttons { get; }
}
