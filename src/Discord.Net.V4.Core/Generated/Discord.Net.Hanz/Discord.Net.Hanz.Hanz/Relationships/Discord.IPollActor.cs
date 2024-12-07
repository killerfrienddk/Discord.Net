using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IPollActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IPollActor, ulong, Discord.IPoll>
    {
        Discord.IPollActor Poll { get; }
    
        Discord.IPollActor Discord.IRelationship<Discord.IPollActor, ulong, Discord.IPoll>.RelationshipActor => Poll;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IPollActor, ulong, Discord.IPoll>
    {
        new Discord.IMessageActor Message => Poll.Message;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
