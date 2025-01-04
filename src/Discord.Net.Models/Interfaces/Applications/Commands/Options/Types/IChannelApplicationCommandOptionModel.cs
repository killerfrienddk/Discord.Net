namespace Discord.Models;

[ModelEquality]
public partial interface IChannelApplicationCommandOptionModel : IApplicationCommandOptionModel
{
    Optional<bool> IsRequired { get; }
    Optional<int[]> ChannelTypes { get; }
}