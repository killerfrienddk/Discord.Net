using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IGlobalApplicationCommandActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IGlobalApplicationCommandActor, ulong, Discord.IGlobalApplicationCommand>
    {
        Discord.IGlobalApplicationCommandActor GlobalApplicationCommand { get; }
    
        Discord.IGlobalApplicationCommandActor Discord.IRelationship<Discord.IGlobalApplicationCommandActor, ulong, Discord.IGlobalApplicationCommand>.RelationshipActor => GlobalApplicationCommand;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IGlobalApplicationCommandActor, ulong, Discord.IGlobalApplicationCommand>,
        Discord.IApplicationCommandActor.CanonicalRelationship
    {
        Discord.IApplicationCommandActor Discord.IApplicationCommandActor.Relationship.ApplicationCommand => GlobalApplicationCommand;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
