using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IRoleActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IRoleActor, ulong, Discord.IRole>
    {
        Discord.IRoleActor Role { get; }
    
        Discord.IRoleActor Discord.IRelationship<Discord.IRoleActor, ulong, Discord.IRole>.RelationshipActor => Role;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IRoleActor, ulong, Discord.IRole>
    {
        new Discord.IGuildActor Guild => Role.Guild;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
