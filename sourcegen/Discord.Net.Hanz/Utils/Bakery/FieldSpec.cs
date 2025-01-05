using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace Discord.Net.Hanz.Utils.Bakery;

public readonly record struct FieldSpec(
    string Name,
    string Type,
    Accessibility Accessibility,
    ImmutableEquatableArray<string>? Modifiers = null,
    string? Initializer = null
)
{
    public ImmutableEquatableArray<string> Modifiers { get; init; } = Modifiers ?? ImmutableEquatableArray<string>.Empty;

    public override string ToString()
    {
        var builder = new StringBuilder();

        builder
            .Append(SyntaxFacts.GetText(Accessibility))
            .Append(' ');

        if (Modifiers.Count > 0)
            builder
                .Append(string.Join(" ", Modifiers))
                .Append(' ');

        builder.Append(Type).Append(' ').Append(Name);

        if (Initializer is not null)
            builder.Append(" = ").Append(Initializer);

        builder.Append(';');

        return builder.ToString();
    }
}