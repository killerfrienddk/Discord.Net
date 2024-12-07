using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IStickerActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IStickerActor, ulong, Discord.ISticker>
    {
        Discord.IStickerActor Sticker { get; }
    
        Discord.IStickerActor Discord.IRelationship<Discord.IStickerActor, ulong, Discord.ISticker>.RelationshipActor => Sticker;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IStickerActor, ulong, Discord.ISticker>;
}
#pragma warning restore CS0108
#pragma warning restore CS0109
