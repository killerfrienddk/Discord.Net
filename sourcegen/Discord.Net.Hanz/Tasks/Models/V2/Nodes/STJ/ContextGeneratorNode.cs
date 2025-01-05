using System.Collections.Immutable;
using System.Text;
using System.Text.Json.SourceGeneration;
using Discord.Net.Hanz.Nodes;
using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace Discord.Net.Hanz.Tasks.V2.Nodes.STJ;

public sealed class ContextGeneratorNode : Node
{
    private GeneratorDriver _driver;
    private readonly JsonSourceGenerator _generator;

    private readonly IncrementalKeyValueProvider<TypeRef, JsonModel> _modelsProvider;

    public ContextGeneratorNode(IncrementalGeneratorInitializationContext context, ILogger logger) : base(context,
        logger)
    {
        _generator = new();
        _driver = CSharpGeneratorDriver.Create(_generator);

        _modelsProvider = GetNode<JsonModelNode>()
            .ModelsProvider;

        context.RegisterSourceOutput(
            _modelsProvider
                .ValuesProvider
                .Collect()
                .Select((models, _) => CreateResolverSpec(models))
        );

        var basicJsonPropertyTypesProvider = _modelsProvider
            .ValuesProvider
            .SelectMany((x, _) => x
                .Properties
                .SelectMany(x => ExtractPropertyInfos(x.TypeInfo))
                .OfType<BasicJsonPropertyTypeInfo>()
            )
            .Collect();

        var contextSourceProvider = basicJsonPropertyTypesProvider.Select(GetContextSourceForSTJ);

        context.RegisterSourceOutput(
            contextSourceProvider
                .Combine(context.CompilationProvider)
                .Select(AddContextToCompilation)
                .Select((compilation, token) => (_driver = _driver.RunGenerators(compilation, token)).GetRunResult())
                .Combine(
                    _modelsProvider
                        .ValuesProvider
                        .SelectMany((x, _) => x
                            .Properties
                            .SelectMany(x => ExtractPropertyInfos(x.TypeInfo))
                            .Where(ShouldGenerate)
                            .Select(x => $"DiscordModelResolver.{x.FriendlyName}.g.cs"))
                        .Collect()
                ),
            ProcessRunResults
        );

        context.RegisterSourceOutput(
            contextSourceProvider,
            (ctx, source) => ctx.AddSource("JsonModels/DiscordModelResolver.Generated", source)
        );

        context.RegisterSourceOutput(
            _modelsProvider
                .ValuesProvider
                .Collect()
                .Select(GenerateInterfaceMapSpec)
        );

        context.RegisterSourceOutput(
            _modelsProvider
                .ValuesProvider
                .Collect()
                .Select(GenerateGetTypeInfoSpec)
        );
    }

    private bool ShouldGenerate(JsonPropertyTypeInfo typeInfo)
    {
        return typeInfo.ShouldGenerateInSTJ && !_modelsProvider.ContainsKey(typeInfo.Type);
    }
    
    private SourceSpec GenerateGetTypeInfoSpec(ImmutableArray<JsonModel> models, CancellationToken token)
    {
        var sb = new StringBuilder();

        sb.AppendLine(
            """
            // interface -> model
            if(InterfaceModelMap.TryGetValue(type, out var modelType))
                return GetTypeInfo(modelType);
                
            """
        );

        var primitives = models
            .SelectMany(x => x
                .Properties
                .SelectMany(x => ExtractPropertyInfos(x.TypeInfo))
                .Where(ShouldGenerate)
            )
            .Distinct()
            .ToArray();

        sb.AppendLine($"// primitives ({primitives.Length})");

        foreach
        (
            var info
            in primitives
        )
        {
            sb.AppendLine(
                $"""
                 if(type == typeof({info.Type}))
                    return Create_{info.FriendlyName}(options);
                 """
            );
        }

        sb.AppendLine().AppendLine($"// models ({models.Length})");

        foreach (var model in models)
        {
            sb.AppendLine(
                $"""
                 if(type == typeof({model.Type}))
                     return {model.Type}.CreateJsonTypeInfo(this);
                 """
            );
        }

        sb.AppendLine().Append("return null;");

        return new SourceSpec(
            "JsonModels/DiscordModelResolver.GetTypeInfo",
            "Discord.Models.Json",
            new([
                "Discord",
                "Discord.Models",
                "Discord.Models.Json",
                "System.Text.Json",
                "System.Text.Json.Serialization",
                "System.Text.Json.Serialization.Metadata",
            ]),
            new([
                new TypeSpec(
                    "DiscordModelResolver",
                    TypeKind.Class,
                    Accessibility.Public,
                    Modifiers: new([
                        "partial"
                    ]),
                    Bases: new(["IJsonTypeInfoResolver"]),
                    Methods: new([
                        new(
                            "GetTypeInfo",
                            "JsonTypeInfo?",
                            Accessibility.Public,
                            new(["override"]),
                            Parameters: new([
                                ("Type", "type")
                            ]),
                            Body:
                            """
                            Options.TryGetTypeInfo(type, out var typeInfo);
                            return typeInfo;
                            """
                        ),
                        new(
                            "GetTypeInfo",
                            "JsonTypeInfo?",
                            ExplicitInterfaceImplementation: "IJsonTypeInfoResolver",
                            Parameters: new([
                                ("Type", "type"),
                                ("JsonSerializerOptions", "options")
                            ]),
                            Body: sb.ToString()
                        )
                    ])
                )
            ])
        );
    }

    private SourceSpec GenerateInterfaceMapSpec(ImmutableArray<JsonModel> models, CancellationToken token)
    {
        return new SourceSpec(
            "JsonModels/DiscordModelResolver.Interfaces",
            "Discord.Models.Json",
            new([
                "Discord",
                "Discord.Models",
                "Discord.Models.Json",
                "System.Text.Json",
                "System.Text.Json.Serialization",
                "System.Text.Json.Serialization.Metadata",
            ]),
            new([
                new TypeSpec(
                    "DiscordModelResolver",
                    TypeKind.Class,
                    Accessibility.Public,
                    Modifiers: new([
                        "partial"
                    ]),
                    Fields: new([
                        new FieldSpec(
                            "InterfaceModelMap",
                            "IReadOnlyDictionary<Type, Type>",
                            Accessibility.Internal,
                            new([
                                "static",
                                "readonly"
                            ]),
                            $$"""
                              new Dictionary<Type, Type>()
                              {
                                  {{
                                      string.Join(
                                          $",{Environment.NewLine}",
                                          models
                                              .Where(x => x.DirectModelInterfaces.Count > 0)
                                              .SelectMany(x => x
                                                  .DirectModelInterfaces
                                                  .Select(iface => $"{{ typeof({iface}), typeof({x.Type}) }}")
                                              )
                                      ).WithNewlinePadding(4)
                                  }}
                              }
                              """
                        )
                    ])
                )
            ])
        );
    }

    private IEnumerable<JsonPropertyTypeInfo> ExtractPropertyInfos(JsonPropertyTypeInfo info)
    {
        yield return info;

        if (info is OptionalJsonPropertyTypeInfo opt)
            foreach (var other in ExtractPropertyInfos(opt.Inner))
                yield return other;
    }

    private static readonly string[] ToInclude = ["DiscordModelResolver.g.cs"];

    private void ProcessRunResults(SourceProductionContext context,
        (GeneratorDriverRunResult, ImmutableArray<string>) tuple)
    {
        var (runResult, targets) = tuple;

        Logger.Clean();
        
        foreach (var result in runResult.Results)
        {
            foreach (var source in result.GeneratedSources)
            {
                if (!targets.Contains(source.HintName) && !ToInclude.Contains(source.HintName))
                {
                    Logger.Log($"Skipping {source.HintName}");
                    continue;
                }
                
                Logger.Log($"Generating {source.HintName}");

                context.AddSource(
                    $"STJ/{source.HintName}",
                    source.SourceText
                );
            }
        }
    }

    private string GetContextSourceForSTJ(ImmutableArray<BasicJsonPropertyTypeInfo> targets, CancellationToken _)
    {
        return
            $"""
             using Discord;
             using Discord.Models;
             using Discord.Models.Json;
             using System.Text.Json;
             using System.Text.Json.Serialization;

             namespace Discord.Models.Json;

             [
                 {
                     string.Join(
                         $",{Environment.NewLine}",
                         targets
                             .Select(x =>
                                 $"JsonSerializable(typeof({x.Type}))"
                             )
                             .Distinct()
                     ).WithNewlinePadding(4)
                 }
             ]
             public partial class DiscordModelResolver : JsonSerializerContext;
             """;
    }

    private Compilation AddContextToCompilation(
        (string, Compilation) tuple,
        CancellationToken token)
    {
        var (source, compilation) = tuple;

        return compilation
            .AddSyntaxTrees(
                CSharpSyntaxTree.ParseText(
                    source,
                    encoding: Encoding.UTF8,
                    options: (CSharpParseOptions) compilation.SyntaxTrees.First().Options,
                    cancellationToken: token
                )!
            );
    }

    private SourceSpec CreateResolverSpec(ImmutableArray<JsonModel> models)
    {
        return new SourceSpec(
            "JsonModels/DiscordModelResolver",
            "Discord.Models.Json",
            new([
                "Discord",
                "Discord.Models",
                "Discord.Models.Json",
                "System.Text.Json",
                "System.Text.Json.Serialization",
                "System.Text.Json.Serialization.Metadata",
            ]),
            new([
                new TypeSpec(
                    "DiscordModelResolver",
                    TypeKind.Class,
                    Accessibility.Public,
                    Modifiers: new([
                        "partial"
                    ]),
                    Properties: new(
                        models.Select(x =>
                            new PropertySpec(
                                $"JsonTypeInfo<{x.Type}>",
                                $"{x.FriendlyName}",
                                Accessibility.Public,
                                Expression: $"GetOrInitTypeInfo(ref _{x.FriendlyName})"
                            )
                        )
                    ),
                    Fields: new(
                        models.Select(x =>
                            new FieldSpec(
                                $"_{x.FriendlyName}",
                                $"JsonTypeInfo<{x.Type}>?",
                                Accessibility.Private
                            )
                        )
                    )
                )
            ])
        );
    }
}