namespace Discord.Models;

[ModelEquality, HasPartialVariant]
public partial interface IGuildChannelModel : IChannelModel
{
    string Name { get; }
    ulong GuildId { get; }
    Optional<ulong?> ParentId { get; }
    int Position { get; }
    IReadOnlyCollection<IOverwriteModel> PermissionOverwrites { get; }
    Optional<int> Flags { get; }
}
