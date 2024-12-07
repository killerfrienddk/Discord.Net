using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IGuildApplicationCommandPermissionsActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IGuildApplicationCommandPermissionsActor, ulong, Discord.IGuildApplicationCommandPermissionses>
    {
        Discord.IGuildApplicationCommandPermissionsActor GuildApplicationCommandPermissions { get; }
    
        Discord.IGuildApplicationCommandPermissionsActor Discord.IRelationship<Discord.IGuildApplicationCommandPermissionsActor, ulong, Discord.IGuildApplicationCommandPermissionses>.RelationshipActor => GuildApplicationCommandPermissions;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IGuildApplicationCommandPermissionsActor, ulong, Discord.IGuildApplicationCommandPermissionses>
    {
        new Discord.IGuildApplicationCommandActor GuildApplicationCommand => GuildApplicationCommandPermissions.GuildApplicationCommand;
    
        new Discord.IGuildActor Guild => GuildApplicationCommandPermissions.GuildApplicationCommand.Guild;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
