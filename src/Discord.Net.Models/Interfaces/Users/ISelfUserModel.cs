using Discord.Models.Json;
using System.Text.Json.Serialization;

namespace Discord.Models;

[ModelEquality]
public partial interface ISelfUserModel : IUserModel
{
    Optional<int> PremiumType { get; }
    Optional<string> Email { get; }
    Optional<bool> IsVerified { get; }
    Optional<string> Locale { get; }
    Optional<bool> MFAEnabled { get; }
}
