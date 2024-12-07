using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IGuildStickerActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IGuildStickerActor, ulong, Discord.IGuildSticker>
    {
        Discord.IGuildStickerActor GuildSticker { get; }
    
        Discord.IGuildStickerActor Discord.IRelationship<Discord.IGuildStickerActor, ulong, Discord.IGuildSticker>.RelationshipActor => GuildSticker;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IGuildStickerActor, ulong, Discord.IGuildSticker>,
        Discord.IStickerActor.CanonicalRelationship
    {
        new Discord.IGuildActor Guild => GuildSticker.Guild;
    
        Discord.IStickerActor Discord.IStickerActor.Relationship.Sticker => GuildSticker;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
