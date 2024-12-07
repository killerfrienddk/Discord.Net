using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IApplicationCommandActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IApplicationCommandActor, ulong, Discord.IApplicationCommand>
    {
        Discord.IApplicationCommandActor ApplicationCommand { get; }
    
        Discord.IApplicationCommandActor Discord.IRelationship<Discord.IApplicationCommandActor, ulong, Discord.IApplicationCommand>.RelationshipActor => ApplicationCommand;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IApplicationCommandActor, ulong, Discord.IApplicationCommand>
    {
        new Discord.IApplicationActor Application => ApplicationCommand.Application;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
