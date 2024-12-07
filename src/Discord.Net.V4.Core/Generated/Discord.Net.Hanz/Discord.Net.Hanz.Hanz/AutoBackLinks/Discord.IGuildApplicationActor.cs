using Discord;

namespace Discord;

public partial interface IGuildApplicationActor
{
    new Discord.IGuildApplicationActor.Indexable.BackLink<Discord.IGuildApplicationActor> Guilds { get; }

    new Discord.IApplicationRoleConnectionMetadataActor.Enumerable.BackLink<Discord.IGuildApplicationActor> RoleConnectionMetadata { get; }

    new Discord.IApplicationEmoteActor.Enumerable.Indexable.BackLink<Discord.IGuildApplicationActor> Emotes { get; }

    new Discord.ISkuActor.Enumerable.BackLink<Discord.IGuildApplicationActor> Skus { get; }

    Discord.IGuildApplicationActor.Indexable Discord.IApplicationActor.Guilds => Guilds;
    Discord.IApplicationRoleConnectionMetadataActor.Enumerable.BackLink<Discord.IApplicationActor> Discord.IApplicationActor.RoleConnectionMetadata => RoleConnectionMetadata;
    Discord.IApplicationEmoteActor.Enumerable.Indexable.BackLink<Discord.IApplicationActor> Discord.IApplicationActor.Emotes => Emotes;
    Discord.ISkuActor.Enumerable Discord.IApplicationActor.Skus => Skus;
}
