using Discord.Rest;

namespace Discord;

public partial interface IInteractionWithIdAndTokenActor
{
    ulong IIdentifiable<ulong>.Id => Id;
}
