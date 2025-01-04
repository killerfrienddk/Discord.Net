
namespace Discord.Models;

[ModelEquality]
public partial interface IThreadMemberModel : IModel
{
    Optional<ulong> ThreadId { get; }
    Optional<ulong> UserId { get; }
    DateTimeOffset JoinTimestamp { get; }
    int Flags { get; }
    Optional<ModelOrId<IMemberModel, ulong>> Member { get; }
}
