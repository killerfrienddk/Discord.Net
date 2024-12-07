using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IGuildChannelInviteActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IGuildChannelInviteActor, string, Discord.IGuildChannelInvite>
    {
        Discord.IGuildChannelInviteActor GuildChannelInvite { get; }
    
        Discord.IGuildChannelInviteActor Discord.IRelationship<Discord.IGuildChannelInviteActor, string, Discord.IGuildChannelInvite>.RelationshipActor => GuildChannelInvite;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IGuildChannelInviteActor, string, Discord.IGuildChannelInvite>,
        Discord.IGuildInviteActor.CanonicalRelationship,
        Discord.IInviteActor.CanonicalRelationship
    {
        new Discord.IGuildChannelActor Channel => GuildChannelInvite.Channel;
    
        new Discord.IGuildActor Guild => GuildChannelInvite.Channel.Guild;
    
        Discord.IGuildInviteActor Discord.IGuildInviteActor.Relationship.GuildInvite => GuildChannelInvite;
        Discord.IInviteActor Discord.IInviteActor.Relationship.Invite => GuildChannelInvite;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
