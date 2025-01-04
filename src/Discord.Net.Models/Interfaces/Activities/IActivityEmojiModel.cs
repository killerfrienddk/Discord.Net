namespace Discord.Models;

// https://discord.com/developers/docs/events/gateway-events#activity-object-activity-emoji
public interface IActivityEmojiModel : IModel
{
    string Name { get; }
    Optional<ulong> Id { get; }
    Optional<bool> IsAnimated { get; }
}