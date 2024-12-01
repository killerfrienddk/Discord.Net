using System.Collections.Immutable;
using Discord.Net.Hanz.Nodes;
using Discord.Net.Hanz.Nodes.TypeNodes;
using Discord.Net.Hanz.Tasks.Actors.Links.Nodes.Modifiers;
using Discord.Net.Hanz.Tasks.Actors.Links.Nodes.Types;
using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;

namespace Discord.Net.Hanz.Tasks.Actors.Nodes;

public sealed partial class ActorNode
{
    private record LinkContext(
        ActorInfo ActorInfo,
        ActorsTask.ActorHierarchy Hierarchy
    )
    {
        public bool RedefinesRootInterfaceMemebrs =>
            !ActorInfo.IsCore || Hierarchy.HasEntityAssignableAncestors;
    }

    private void CreateLinks(IncrementalGeneratorInitializationContext context)
    {
        // var buildProvider = AddNestedTypes(
        //         ContainersProvider,
        //         (state, _) => new(state.ActorInfo, state.Path),
        //         GetNode<HierarchyNode>(),
        //         GetNode<BackLinkNode>(),
        //         GetNode<ExtensionNode>(),
        //         GetNode<LinkTypeNode>()
        //     )
        //     .Collect()
        //     .SelectMany(Introspect)
        //     .Select(CreateLinkInterface);

        var typeRoot = new NestedTypeRoot<ActorInfo>(
            GetTask<ActorsTask>()
                .ActorInfos
                .ValuesProvider
                .Select((x, _) => (x, TypePath.Empty.Add<ActorNode>(x.Actor.ReferenceName)))
        );

        typeRoot.AddChild(GetNode<LinkTypeNode>());
        typeRoot.AddChild(GetNode<BackLinkNode>());
        typeRoot.AddChild(GetNode<ExtensionNode>());
        typeRoot.AddChild(GetNode<HierarchyNode>());

        context.RegisterSourceOutput(
            typeRoot
                .Build(Logger.GetSubLogger("BuildTypeRoot"))
                .ToKeyed((info, specs) =>
                    TypeSpec.From(info.Actor) with
                    {
                        Modifiers = new(["partial"]),
                        Children = specs.ToImmutableEquatableArray()
                    }
                )
                .JoinByKey(
                    GetTask<ActorsTask>()
                        .ActorHierarchies
                        .MapValues((info, hierarchy) => new LinkContext(info, hierarchy))
                        .MapValues((info, context) => CreateLinkInterface(context)),
                    (info, container, linkInterface) => container.AddNestedType(linkInterface)
                )
                .Select((actorInfo, spec) =>
                    new SourceSpec(
                        $"Links/{actorInfo.Actor.MetadataName}",
                        actorInfo.Actor.Namespace,
                        new ImmutableEquatableArray<string>([
                            "Discord",
                            "Discord.Models",
                            "MorseCode.ITask"
                        ]),
                        new([
                            spec
                        ]),
                        new([
                            "CS0108",
                            "CS0109"
                        ])
                    )
                )
                .Select((x, _) =>
                {
                    using var logger = Logger
                        .GetSubLogger("Output")
                        .GetSubLogger(x.Path.Split('/')[1])
                        .WithCleanLogFile();

                    logger.Log(x.ToString());

                    return x;
                })
        );
    }

    private TypeSpec CreateLinkInterface(LinkContext context)
    {
        var linkType = new TypeSpec(
            "Link",
            TypeKind.Interface,
            Bases: new([
                context.ActorInfo.FormattedLink
            ])
        );

        if (context.Hierarchy.HasAncestors || !context.ActorInfo.IsCore)
        {
            linkType = linkType.AddModifiers("new");
        }

        if (!context.ActorInfo.IsCore)
            linkType = linkType.AddBases(context.ActorInfo.FormattedCoreLink);

        if (context.RedefinesRootInterfaceMemebrs)
        {
            linkType = linkType
                .AddInterfaceMethodOverload(
                    context.ActorInfo.Actor.DisplayString,
                    context.ActorInfo.FormattedActorProvider,
                    "GetActor",
                    [
                        new ParameterSpec(
                            context.ActorInfo.Id.DisplayString,
                            "id"
                        )
                    ],
                    expression: "GetActor(id)"
                )
                .AddInterfaceMethodOverload(
                    context.ActorInfo.Entity.DisplayString,
                    context.ActorInfo.FormattedEntityProvider,
                    "CreateEntity",
                    [
                        new ParameterSpec(
                            context.ActorInfo.Model.DisplayString,
                            "model"
                        )
                    ],
                    expression: "CreateEntity(model)"
                );
        
            if (!context.ActorInfo.IsCore)
            {
                linkType = linkType
                    .AddInterfaceMethodOverload(
                        context.ActorInfo.CoreActor.DisplayString,
                        context.ActorInfo.FormattedCoreActorProvider,
                        "GetActor",
                        [
                            new ParameterSpec(
                                context.ActorInfo.Id.DisplayString,
                                "id"
                            )
                        ],
                        expression: "GetActor(id)"
                    )
                    .AddInterfaceMethodOverload(
                        context.ActorInfo.CoreEntity.DisplayString,
                        context.ActorInfo.FormattedCoreEntityProvider,
                        "CreateEntity",
                        [
                            new ParameterSpec(
                                context.ActorInfo.Model.DisplayString,
                                "model"
                            )
                        ],
                        expression: "CreateEntity(model)"
                    );
            }
        }

        foreach (var ancestor in context.Hierarchy.Parents)
        {
            var ancestorActorProviderTarget = ancestor.HasEntityAssignableAncestors
                ? $"{ancestor.ActorInfo.Actor}.Link"
                : ancestor.ActorInfo.FormattedActorProvider;

            var ancestorEntityProviderTarget = ancestor.HasEntityAssignableAncestors
                ? $"{ancestor.ActorInfo.Actor}.Link"
                : ancestor.ActorInfo.FormattedEntityProvider;

            linkType = linkType
                .AddBases($"{ancestor.ActorInfo.Actor}.Link")
                .AddInterfaceMethodOverload(
                    ancestor.ActorInfo.Actor.DisplayString,
                    ancestorActorProviderTarget,
                    "GetActor",
                    [(ancestor.ActorInfo.Id.DisplayString, "id")],
                    expression: "GetActor(id)"
                )
                .AddInterfaceMethodOverload(
                    ancestor.ActorInfo.Entity.DisplayString,
                    ancestorEntityProviderTarget,
                    "CreateEntity",
                    [(ancestor.ActorInfo.Model.DisplayString, "model")],
                    expression: "CreateEntity(model)"
                );
        }

        return linkType;
    }
}