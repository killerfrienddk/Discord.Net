using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IApplicationEmoteActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IApplicationEmoteActor, ulong, Discord.IApplicationEmote>
    {
        Discord.IApplicationEmoteActor ApplicationEmote { get; }
    
        Discord.IApplicationEmoteActor Discord.IRelationship<Discord.IApplicationEmoteActor, ulong, Discord.IApplicationEmote>.RelationshipActor => ApplicationEmote;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IApplicationEmoteActor, ulong, Discord.IApplicationEmote>
    {
        new Discord.IApplicationActor Application => ApplicationEmote.Application;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
