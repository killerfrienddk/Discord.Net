using System.Text.Json.Serialization;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IPartialDMChannelModel : 
    IPartialModel,
    IEntityModel<ulong>,
    Discord.Models.IPartialChannelModel
{
    Discord.Optional<Discord.Models.ModelOrId<Discord.Models.IUserModel, ulong>> Recipient { get; }

    Type IPartialModel.UnderlyingModelType => typeof(Discord.Models.IDMChannelModel);
}
