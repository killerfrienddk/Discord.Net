namespace Discord;

public partial interface IGuildSoundboardSoundActor : 
    Discord.IDeletable<ulong, Discord.IGuildSoundboardSoundActor>
{
    static IApiRoute Discord.IDeletable<ulong, Discord.IGuildSoundboardSoundActor>.DeleteRoute(IPathable path, ulong id) => Discord.Rest.Routes.DeleteGuildSoundboardSound(id, id);
}
