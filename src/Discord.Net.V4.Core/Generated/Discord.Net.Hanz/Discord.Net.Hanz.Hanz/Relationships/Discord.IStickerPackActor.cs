using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IStickerPackActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IStickerPackActor, ulong, Discord.IStickerPack>
    {
        Discord.IStickerPackActor StickerPack { get; }
    
        Discord.IStickerPackActor Discord.IRelationship<Discord.IStickerPackActor, ulong, Discord.IStickerPack>.RelationshipActor => StickerPack;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IStickerPackActor, ulong, Discord.IStickerPack>;
}
#pragma warning restore CS0108
#pragma warning restore CS0109
