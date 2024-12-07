namespace Discord;

public partial interface IGuildStickerActor : 
    Discord.IDeletable<ulong, Discord.IGuildStickerActor>
{
    static IApiRoute Discord.IDeletable<ulong, Discord.IGuildStickerActor>.DeleteRoute(IPathable path, ulong id) => Discord.Rest.Routes.DeleteGuildSticker(id, id);
}
