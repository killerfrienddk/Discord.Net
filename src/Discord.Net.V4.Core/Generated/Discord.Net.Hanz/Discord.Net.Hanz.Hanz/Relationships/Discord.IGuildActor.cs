using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IGuildActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IGuildActor, ulong, Discord.IGuild>
    {
        Discord.IGuildActor Guild { get; }
    
        Discord.IGuildActor Discord.IRelationship<Discord.IGuildActor, ulong, Discord.IGuild>.RelationshipActor => Guild;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IGuildActor, ulong, Discord.IGuild>;
}
#pragma warning restore CS0108
#pragma warning restore CS0109
