using System.Text.Json;
using System.Text.Json.Serialization.Metadata;

namespace Discord.Models.Json;

public sealed partial class DiscordModelResolver
{
    private JsonTypeInfo<T> GetOrInitTypeInfo<T>(ref JsonTypeInfo<T>? info)
        where T : ISTJModel<T>
    {
        if (info is not null)
            return info;

        info = T.CreateJsonTypeInfo(this);
        info.OriginatingResolver = this;
        return info;
    }
}