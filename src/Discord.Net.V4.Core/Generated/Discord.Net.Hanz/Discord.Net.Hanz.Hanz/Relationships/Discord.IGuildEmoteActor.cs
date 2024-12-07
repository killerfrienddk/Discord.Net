using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IGuildEmoteActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IGuildEmoteActor, ulong, Discord.IGuildEmote>
    {
        Discord.IGuildEmoteActor GuildEmote { get; }
    
        Discord.IGuildEmoteActor Discord.IRelationship<Discord.IGuildEmoteActor, ulong, Discord.IGuildEmote>.RelationshipActor => GuildEmote;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IGuildEmoteActor, ulong, Discord.IGuildEmote>
    {
        new Discord.IGuildActor Guild => GuildEmote.Guild;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
