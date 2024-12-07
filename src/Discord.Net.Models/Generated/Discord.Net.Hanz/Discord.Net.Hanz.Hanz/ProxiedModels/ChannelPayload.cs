using System.Text.Json.Serialization;

namespace Discord.Models.Json;

public sealed partial class ChannelPayload : IExtendedModel<Discord.Models.Json.Channel>
{
    Discord.Models.Json.Channel IExtendedModel<Discord.Models.Json.Channel>.ExtendedValue => Channel;

    uint Discord.Models.IChannelModel.Type => (Channel as Discord.Models.IChannelModel).Type;

    ulong Discord.Models.IEntityModel<ulong>.Id => (Channel as Discord.Models.IEntityModel<ulong>).Id;
}