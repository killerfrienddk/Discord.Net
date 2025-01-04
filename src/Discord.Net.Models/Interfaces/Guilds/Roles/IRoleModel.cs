using System.Numerics;

namespace Discord.Models;

[ModelEquality]
public partial interface IRoleModel : IEntityModel<ulong>
{
    string Name { get; }
    uint Color { get; }
    bool IsHoisted { get; }
    Optional<string> Icon { get; }
    Optional<string> UnicodeEmoji { get; }
    int Position { get; }
    string Permissions { get; }
    bool IsManaged { get; }
    bool IsMentionable { get; }
    int Flags { get; }

    Optional<IRoleTagsModel> Tags { get; }
}