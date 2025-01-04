using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Discord.Net.Hanz.Tasks.V2.Nodes;

public sealed class OptionalPropertyProcessor : IJsonPropertyProcessorNode
{
    public static readonly OptionalPropertyProcessor Instance = new();

    public void Process(
        ref PropertyDeclarationSyntax syntax,
        Compilation compilation, 
        JsonModel model,
        JsonProperty property)
    {
        syntax = syntax
            .WithAttributeLists(
                syntax.AttributeLists.Add(
                    SyntaxFactory.AttributeList(
                        SyntaxFactory.SeparatedList([
                            SyntaxFactory.Attribute(
                                SyntaxFactory.IdentifierName("JsonIgnore"),
                                SyntaxFactory.AttributeArgumentList(
                                    SyntaxFactory.SeparatedList([
                                        SyntaxFactory.AttributeArgument(
                                            SyntaxFactory.NameEquals("Condition"),
                                            null,
                                            SyntaxFactory.MemberAccessExpression(
                                                SyntaxKind.SimpleMemberAccessExpression,
                                                SyntaxFactory.IdentifierName("JsonIgnoreCondition"),
                                                SyntaxFactory.IdentifierName("WhenWritingDefault")
                                            )
                                        )
                                    ])
                                )
                            ),
                            SyntaxFactory.Attribute(
                                SyntaxFactory.IdentifierName("JsonConverter"),
                                SyntaxFactory.AttributeArgumentList(
                                    SyntaxFactory.SeparatedList([
                                        SyntaxFactory.AttributeArgument(
                                            SyntaxFactory.TypeOfExpression(
                                                SyntaxFactory.ParseTypeName(
                                                    $"Discord.Converters.OptionalConverter<{property.OptionalInnerType}>"
                                                )
                                            )
                                        )
                                    ])
                                )
                            ),
                        ])
                    )
                )
            );
    }
}