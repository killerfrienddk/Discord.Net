using Discord.Models;
using Discord.Rest;
using System.Diagnostics.CodeAnalysis;

namespace Discord;

public partial interface IGuildSticker
{
    Discord.Models.IGuildStickerModel IEntityOf<IGuildStickerModel>.GetModel() => GetModel();

    Discord.Models.IStickerModel IEntityOf<IStickerModel>.GetModel() => GetModel();
}
