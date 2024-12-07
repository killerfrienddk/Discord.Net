using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IGuildApplicationCommandActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IGuildApplicationCommandActor, ulong, Discord.IGuildApplicationCommand>
    {
        Discord.IGuildApplicationCommandActor GuildApplicationCommand { get; }
    
        Discord.IGuildApplicationCommandActor Discord.IRelationship<Discord.IGuildApplicationCommandActor, ulong, Discord.IGuildApplicationCommand>.RelationshipActor => GuildApplicationCommand;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IGuildApplicationCommandActor, ulong, Discord.IGuildApplicationCommand>,
        Discord.IApplicationCommandActor.CanonicalRelationship
    {
        new Discord.IGuildActor Guild => GuildApplicationCommand.Guild;
    
        Discord.IApplicationCommandActor Discord.IApplicationCommandActor.Relationship.ApplicationCommand => GuildApplicationCommand;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
