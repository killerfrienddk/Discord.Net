using System.Text.Json.Serialization;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IPartialIntegrationModel : 
    IPartialModel,
    IEntityModel<ulong>
{
    Discord.Optional<string> Name { get; }

    Discord.Optional<string> Type { get; }

    Discord.Optional<bool> IsEnabled { get; }

    Discord.Optional<bool> IsSyncing { get; }

    Discord.Optional<ulong> RoleId { get; }

    Discord.Optional<bool> EnableEmoticons { get; }

    Discord.Optional<int> ExpireBehavior { get; }

    Discord.Optional<int> ExpireGracePeriod { get; }

    Discord.Optional<Discord.Models.ModelOrId<Discord.Models.IUserModel, ulong>> User { get; }

    Discord.Optional<Discord.Models.IIntegrationAccountModel> Account { get; }

    Discord.Optional<System.DateTimeOffset> SyncedAt { get; }

    Discord.Optional<int> SubscriberCount { get; }

    Discord.Optional<bool> IsRevoked { get; }

    Discord.Optional<Discord.Models.IIntegrationApplicationModel> Application { get; }

    Discord.Optional<string[]?> Scopes { get; }

    Type IPartialModel.UnderlyingModelType => typeof(Discord.Models.IIntegrationModel);
}
