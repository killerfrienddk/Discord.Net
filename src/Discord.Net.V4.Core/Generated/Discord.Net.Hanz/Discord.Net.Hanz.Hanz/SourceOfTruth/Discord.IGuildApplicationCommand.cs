using Discord.Rest;

namespace Discord;

public partial interface IGuildApplicationCommand
{
    Discord.IGuildActor? IApplicationCommand.Guild => Guild;
}
