using System.Text;
using Discord.Net.Hanz.Nodes;
using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;

namespace Discord.Net.Hanz.Tasks.V2.Nodes.STJ;

public sealed class TypeInfoGeneratorNode : Node
{
    public TypeInfoGeneratorNode(IncrementalGeneratorInitializationContext context, ILogger logger) : base(context,
        logger)
    {
        context.RegisterSourceOutput(
            GetNode<JsonModelNode>()
                .ModelsProvider
                .Select(CreateTypeInfo)
        );
    }

    private SourceSpec CreateTypeInfo(JsonModel model)
    {
        var typeSpec = TypeSpec.From(model.Type)
            .AddModifiers("partial")
            .AddBases($"ISTJModel<{model.Type}>")
            .AddMethods(
                CreateGetTypeInfoMethod(model),
                CreateSerializeMethod(model),
                CreateGetPropertyInfoSpec(model),
                new(
                    "CreateJsonTypeInfo",
                    $"JsonTypeInfo<{model.Type}>",
                    Modifiers: new(["static"]),
                    Parameters: new([
                        ("DiscordModelResolver", "resolver")
                    ]),
                    ExplicitInterfaceImplementation: $"ISTJModel<{model.Type}>",
                    Expression: "CreateJsonTypeInfo(resolver)"
                ),
                new(
                    "Serialize",
                    $"void",
                    Modifiers: new(["static"]),
                    Parameters: new([
                        ("Utf8JsonWriter", "writer"),
                        ($"{model.Type}?", "model"),
                        ("DiscordModelResolver", "resolver"),
                    ]),
                    ExplicitInterfaceImplementation: $"ISTJModel<{model.Type}>",
                    Expression: "Serialize(writer, model, resolver)"
                )
            )
            .AddFields(
                model
                    .Properties
                    .Where(x => x.JsonName is not null)
                    .Select(x => new FieldSpec(
                        $"__JsonPropName{x.Name}",
                        "JsonEncodedText",
                        Accessibility.Private,
                        new([
                            "static",
                            "readonly"
                        ]),
                        Initializer: $"JsonEncodedText.Encode({x.JsonName.Quote()})"
                    ))
            );

        if (model.Constructor?.ConstructorParams.Count > 0 || model.Constructor?.PropertiesInit.Count > 0)
            typeSpec = typeSpec.AddMethods(CreateGetCtorParamsInfoMethod(model));

        return new SourceSpec(
            $"JsonModels/{model.Type.MetadataName}",
            model.Type.Namespace!,
            new([
                "Discord",
                "Discord.Models",
                "Discord.Models.Json",
                "System.Text.Json",
                "System.Text.Json.Serialization",
                "System.Text.Json.Serialization.Metadata",
            ]),
            new([
                typeSpec
            ])
        );
    }

    private MethodSpec CreateSerializeMethod(JsonModel model)
    {
        var sb = new StringBuilder();

        sb.AppendLine(
            """
            if(model is null)
            {
                writer.WriteNullValue();
                return;
            }

            writer.WriteStartObject();

            """
        );

        foreach (var property in model.Properties)
        {
            var propName = property.JsonName is not null
                ? $"__JsonPropName{property.Name}"
                : property.Name.Quote();

            sb.AppendLine($"// \"{property.Name}\" of type \"{property.TypeInfo.Type}\"")
                .AppendLine(FormatAsWriter(propName, $"model.{property.Name}", property.TypeInfo))
                .AppendLine();
        }

        sb.AppendLine("writer.WriteEndObject();");

        return new MethodSpec(
            "Serialize",
            "void",
            Accessibility.Internal,
            new(["static"]),
            new([
                ("Utf8JsonWriter", "writer"),
                ($"{model.Type}?", "model"),
                ("DiscordModelResolver", "resolver")
            ]),
            Body: sb.ToString()
        );

        string FormatAsWriter(string propertyNameExpression, string valueExpression, JsonPropertyTypeInfo typeInfo)
        {
            switch (typeInfo)
            {
                case OptionalJsonPropertyTypeInfo(var type, _, var inner):
                    return
                        $$"""
                          if({{valueExpression}}.IsSpecified)
                          {
                              {{FormatAsWriter(propertyNameExpression, $"{valueExpression}.Value", inner).WithNewlinePadding(4)}}
                          }
                          """;
                case PrimitiveJsonPropertyTypeInfo(var type, _, var primitiveKind):
                    var writeMethod = primitiveKind switch
                    {
                        JsonPrimitiveKind.Number => "WriteNumber",
                        JsonPrimitiveKind.String or JsonPrimitiveKind.Char => "WriteString",
                        JsonPrimitiveKind.Boolean => "WriteBoolean",
                        JsonPrimitiveKind.ByteArray => "WriteBase64String",
                        _ => null
                    };

                    if (writeMethod != null)
                        return primitiveKind is JsonPrimitiveKind.Char
                            ? $"writer.{writeMethod}({propertyNameExpression}, {valueExpression}.ToString());"
                            : $"writer.{writeMethod}({propertyNameExpression}, {valueExpression});";

                    goto default;
                default:
                    if (GetNode<JsonModelNode>().ModelsProvider.TryGetValue(typeInfo.Type, out var model))
                        return
                            $"""
                             writer.WritePropertyName({propertyNameExpression});
                             JsonSerializer.Serialize(writer, {valueExpression}, resolver.{model.FriendlyName}JsonTypeInfo);
                             """;
                    return
                        $"""
                         writer.WritePropertyName({propertyNameExpression});
                         JsonSerializer.Serialize(writer, {valueExpression}, resolver.Options);
                         """;
            }
        }
    }


    private MethodSpec CreateGetCtorParamsInfoMethod(JsonModel model)
    {
        if (model.Constructor is null) throw new NullReferenceException("Constructor is null");

        var sb = new StringBuilder();

        int parameterIndex = 0;

        foreach (var ctorParam in model.Constructor.ConstructorParams)
        {
            sb.AppendLine(
                $$"""
                  parameters[{{parameterIndex++}}] = new()
                  {
                      Name = {{ctorParam.Name.Quote()}},
                      ParameterType = typeof({{ctorParam.Type}}),
                      Position = {{ctorParam.Position}},
                      HasDefaultValue = {{ctorParam.HasDefaultValue.ToString().ToLowerInvariant()}},
                      DefaultValue = {{ctorParam.DefaultValue}}
                  };
                  """
            );
        }

        foreach (var propName in model.Constructor.PropertiesInit)
        {
            var prop = model.Properties.First(x => x.Name == propName);
            var i = parameterIndex++;
            sb.AppendLine(
                $$"""
                  parameters[{{i}}] = new()
                  {
                      Name = {{propName.Quote()}},
                      ParameterType = typeof({{prop.TypeInfo.Type}}),
                      Position = {{i}}
                  };
                  """
            );
        }

        return new MethodSpec(
            "GetCtorParamsInfo",
            "JsonParameterInfoValues[]",
            Accessibility.Internal,
            new(["static"]),
            Body:
            $"""
             var parameters = new JsonParameterInfoValues[{parameterIndex}];

             {sb}

             return parameters;
             """
        );
    }

    private MethodSpec CreateGetTypeInfoMethod(JsonModel model)
    {
        var hasEmptyConstructor = model.Constructor is null or {ConstructorParams.Count: 0, PropertiesInit.Count: 0};
        var hasConstructorParams = model.Constructor?.ConstructorParams.Count > 0 || model.Constructor?.PropertiesInit.Count > 0;

        var objectCreator = hasEmptyConstructor
            ? $"() => new {model.Type}()"
            : "null";

        return new MethodSpec(
            "CreateJsonTypeInfo",
            $"JsonTypeInfo<{model.Type}>",
            Accessibility.Internal,
            new(["static"]),
            new([
                ("DiscordModelResolver", "resolver"),
            ]),
            Expression:
            $$"""
              JsonMetadataServices.CreateObjectInfo<{{model.Type}}>(resolver.Options, new JsonObjectInfoValues<{{model.Type}}>
              {
                  ObjectCreator = {{objectCreator}},
                  ObjectWithParameterizedConstructorCreator = {{BuildParameterizedConstructorCreator()}},
                  PropertyMetadataInitializer = _ => {{model.Type}}.GetPropertyInfos(resolver.Options),
                  ConstructorParameterMetadataInitializer = {{(
                      hasConstructorParams ? $"{model.Type}.GetCtorParamsInfo" : "null"
                  )}},
                  SerializeHandler = (writer, model) => {{model.Type}}.Serialize(writer, model, resolver)
              })
              """
        );

        string BuildParameterizedConstructorCreator()
        {
            if (hasEmptyConstructor || model.Constructor is null) return "null";

            var sb = new StringBuilder($"static args => new {model.Type}");

            int argsIndex = 0;

            if (model.Constructor.ConstructorParams.Count > 0)
            {
                sb.Append("(");

                foreach (var param in model.Constructor.ConstructorParams)
                {
                    sb.Append($"({param.Type})args[{argsIndex++}], ");
                }

                sb.Length -= 2;
                sb.Append(")");
            }

            if (model.Constructor.PropertiesInit.Count > 0)
            {
                sb.Append("{ ");

                foreach (var prop in model.Constructor.PropertiesInit)
                {
                    var type = model.Properties.First(x => x.Name == prop).TypeInfo.Type;

                    sb.Append($"{prop} = ({type})args[{argsIndex++}], ");
                }

                sb.Length -= 2;
                sb.Append(" }");
            }

            return sb.ToString();
        }
    }

    private MethodSpec CreateGetPropertyInfoSpec(JsonModel model)
    {
        var sb = new StringBuilder();

        sb.AppendLine($"var props = new JsonPropertyInfo[{model.Properties.Count}];");

        for (var i = 0; i < model.Properties.Count; i++)
        {
            var property = model.Properties[i];

            var getter = property.CanGet
                ? $"static obj => (({model.Type})obj).{property.Name}"
                : "null";

            var setter = property.CanSet
                ? $"static (obj, value) => (({model.Type})obj).{property.Name} = value!"
                : "null";

            var ignoreCondition = property.TypeInfo is OptionalJsonPropertyTypeInfo
                ? "JsonIgnoreCondition.WhenWritingDefault"
                : "null";

            sb.AppendLine(
                $$"""
                  props[{{i}}] = JsonMetadataServices.CreatePropertyInfo<{{property.TypeInfo.Type}}>(options, new()
                  {
                      IsProperty = true,
                      IsPublic = true,
                      DeclaringType = typeof({{model.Type}}),
                      Getter = {{getter}},
                      Setter = {{setter}},
                      PropertyName = {{property.Name.Quote()}},
                      JsonPropertyName = {{property.JsonName.Quote()}},
                      IgnoreCondition = {{ignoreCondition}}
                  });
                  """
            );
        }

        sb.Append("return props;");

        return new MethodSpec(
            "GetPropertyInfos",
            "JsonPropertyInfo[]",
            Accessibility.Internal,
            new(["static"]),
            new([
                ("JsonSerializerOptions", "options"),
            ]),
            Body: sb.ToString()
        );
    }
}