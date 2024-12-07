using Discord;

namespace Discord;

public partial interface ICurrentApplicationActor
{
    new Discord.IGuildApplicationActor.Indexable.BackLink<Discord.ICurrentApplicationActor> Guilds { get; }

    new Discord.IApplicationRoleConnectionMetadataActor.Enumerable.BackLink<Discord.ICurrentApplicationActor> RoleConnectionMetadata { get; }

    new Discord.IApplicationEmoteActor.Enumerable.Indexable.BackLink<Discord.ICurrentApplicationActor> Emotes { get; }

    new Discord.ISkuActor.Enumerable.BackLink<Discord.ICurrentApplicationActor> Skus { get; }

    Discord.IGuildApplicationActor.Indexable Discord.IApplicationActor.Guilds => Guilds;
    Discord.IApplicationRoleConnectionMetadataActor.Enumerable.BackLink<Discord.IApplicationActor> Discord.IApplicationActor.RoleConnectionMetadata => RoleConnectionMetadata;
    Discord.IApplicationEmoteActor.Enumerable.Indexable.BackLink<Discord.IApplicationActor> Discord.IApplicationActor.Emotes => Emotes;
    Discord.ISkuActor.Enumerable Discord.IApplicationActor.Skus => Skus;
}
