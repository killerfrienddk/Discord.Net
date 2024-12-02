using Discord.Net.Hanz.Utils.Bakery;

namespace Discord.Net.Hanz.Tasks.Actors.Links.Methods;

public record MethodTemplateSpec(
    string? Body,
    string? Expression,
    ImmutableEquatableArray<string> Usings,
    MethodSpec Template
);