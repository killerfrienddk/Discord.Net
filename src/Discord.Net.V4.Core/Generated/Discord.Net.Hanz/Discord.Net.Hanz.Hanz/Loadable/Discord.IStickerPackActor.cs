using Discord;
using Discord.Models;
using Discord.Rest;

namespace Discord;

public partial interface IStickerPackActor : 
    Discord.ILoadable<Discord.IStickerPackActor, ulong, Discord.IStickerPack, Discord.Models.IStickerPackModel>;
