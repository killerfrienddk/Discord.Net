using System.Text.Json;
using System.Text.Json.Serialization.Metadata;

namespace Discord.Models.Json;

public interface ISTJModel<TSelf>
    where TSelf : ISTJModel<TSelf>
{
    internal static abstract JsonTypeInfo<TSelf> CreateJsonTypeInfo(DiscordModelResolver resolver);

    internal static abstract void Serialize(
        Utf8JsonWriter writer,
        TSelf? model,
        DiscordModelResolver resolver
    );
}