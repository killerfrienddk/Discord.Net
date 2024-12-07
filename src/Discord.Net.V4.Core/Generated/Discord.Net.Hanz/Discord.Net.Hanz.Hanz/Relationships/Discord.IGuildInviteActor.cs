using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IGuildInviteActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IGuildInviteActor, string, Discord.IGuildInvite>
    {
        Discord.IGuildInviteActor GuildInvite { get; }
    
        Discord.IGuildInviteActor Discord.IRelationship<Discord.IGuildInviteActor, string, Discord.IGuildInvite>.RelationshipActor => GuildInvite;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IGuildInviteActor, string, Discord.IGuildInvite>,
        Discord.IInviteActor.CanonicalRelationship
    {
        new Discord.IGuildActor Guild => GuildInvite.Guild;
    
        Discord.IInviteActor Discord.IInviteActor.Relationship.Invite => GuildInvite;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
