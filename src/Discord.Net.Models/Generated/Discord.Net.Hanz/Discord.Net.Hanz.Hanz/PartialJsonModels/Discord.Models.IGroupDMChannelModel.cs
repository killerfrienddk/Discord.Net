using System.Text.Json.Serialization;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IPartialGroupDMChannelModel : 
    IPartialModel,
    IEntityModel<ulong>,
    Discord.Models.IPartialChannelModel
{
    Discord.Optional<System.Collections.Generic.IReadOnlyCollection<Discord.Models.ModelOrId<Discord.Models.IUserModel, ulong>>> Recipients { get; }

    Discord.Optional<ulong> OwnerId { get; }

    Type IPartialModel.UnderlyingModelType => typeof(Discord.Models.IGroupDMChannelModel);
}
