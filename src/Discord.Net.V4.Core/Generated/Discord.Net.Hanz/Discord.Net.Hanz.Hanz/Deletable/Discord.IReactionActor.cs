namespace Discord;

public partial interface IReactionActor : 
    Discord.IDeletable<Discord.DiscordEmojiId, Discord.IReactionActor>
{
    static IApiRoute Discord.IDeletable<Discord.DiscordEmojiId, Discord.IReactionActor>.DeleteRoute(IPathable path, Discord.DiscordEmojiId id) => Discord.Rest.Routes.DeleteAllReactionsForEmoji(path.Require<Discord.IChannel>(), path.Require<Discord.IMessage>(), id);
}
