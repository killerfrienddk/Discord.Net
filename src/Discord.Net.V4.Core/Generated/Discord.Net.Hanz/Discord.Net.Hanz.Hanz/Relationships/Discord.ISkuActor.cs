using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface ISkuActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.ISkuActor, ulong, Discord.ISku>
    {
        Discord.ISkuActor Sku { get; }
    
        Discord.ISkuActor Discord.IRelationship<Discord.ISkuActor, ulong, Discord.ISku>.RelationshipActor => Sku;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.ISkuActor, ulong, Discord.ISku>
    {
        new Discord.IApplicationActor Application => Sku.Application;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
