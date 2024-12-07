using System.Text.Json.Serialization;

namespace Discord.Models.Json;

public sealed partial class IntegrationCreatedUpdated : IExtendedModel<Discord.Models.Json.Integration>
{
    Discord.Models.Json.Integration IExtendedModel<Discord.Models.Json.Integration>.ExtendedValue => Integration;

    string Discord.Models.IIntegrationModel.Name => (Integration as Discord.Models.IIntegrationModel).Name;

    string Discord.Models.IIntegrationModel.Type => (Integration as Discord.Models.IIntegrationModel).Type;

    bool Discord.Models.IIntegrationModel.IsEnabled => (Integration as Discord.Models.IIntegrationModel).IsEnabled;

    bool? Discord.Models.IIntegrationModel.IsSyncing => (Integration as Discord.Models.IIntegrationModel).IsSyncing;

    ulong? Discord.Models.IIntegrationModel.RoleId => (Integration as Discord.Models.IIntegrationModel).RoleId;

    bool? Discord.Models.IIntegrationModel.EnableEmoticons => (Integration as Discord.Models.IIntegrationModel).EnableEmoticons;

    int? Discord.Models.IIntegrationModel.ExpireBehavior => (Integration as Discord.Models.IIntegrationModel).ExpireBehavior;

    int? Discord.Models.IIntegrationModel.ExpireGracePeriod => (Integration as Discord.Models.IIntegrationModel).ExpireGracePeriod;

    ulong? Discord.Models.IIntegrationModel.UserId => (Integration as Discord.Models.IIntegrationModel).UserId;

    Discord.Models.IIntegrationAccountModel? Discord.Models.IIntegrationModel.Account => (Integration as Discord.Models.IIntegrationModel).Account;

    System.DateTimeOffset? Discord.Models.IIntegrationModel.SyncedAt => (Integration as Discord.Models.IIntegrationModel).SyncedAt;

    int? Discord.Models.IIntegrationModel.SubscriberCount => (Integration as Discord.Models.IIntegrationModel).SubscriberCount;

    bool? Discord.Models.IIntegrationModel.IsRevoked => (Integration as Discord.Models.IIntegrationModel).IsRevoked;

    IPartialApplicationModel? Discord.Models.IIntegrationModel.Application => (Integration as Discord.Models.IIntegrationModel).Application;

    string[]? Discord.Models.IIntegrationModel.Scopes => (Integration as Discord.Models.IIntegrationModel).Scopes;

    ulong Discord.Models.IEntityModel<ulong>.Id => (Integration as Discord.Models.IEntityModel<ulong>).Id;
}