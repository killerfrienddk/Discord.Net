namespace Discord.Models;

[ModelEquality]
public partial interface IChannelFollowerWebhookModel : IWebhookModel
{
    ulong GuildId { get; }
    ulong ChannelId { get; }
    
    Optional<ModelOrId<IPartialGuildModel, ulong>> SourceGuild { get; }
    Optional<ModelOrId<IPartialChannelModel, ulong>> SourceChannel { get; }
}