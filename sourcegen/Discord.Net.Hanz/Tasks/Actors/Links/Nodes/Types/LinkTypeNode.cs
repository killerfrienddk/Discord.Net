using System.Collections.Immutable;
using Discord.Net.Hanz.Nodes.TypeNodes;
using Discord.Net.Hanz.Tasks.Actors.Common;
using Discord.Net.Hanz.Tasks.Actors.Links.Nodes.Modifiers;
using Discord.Net.Hanz.Tasks.Actors.Nodes;
using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;

namespace Discord.Net.Hanz.Tasks.Actors.Links.Nodes.Types;

public class LinkTypeNode :
    LinkNode,
    ITypeProducerNode<LinkTypeNode.State>.WithParameters<ActorInfo>.Introspects<AncestorPathingIntrospection>
{
    public record State(
        ActorInfo ActorInfo,
        TypePath Path,
        LinkSchematics.Entry Entry
    ) : IPathedState
    {
        public bool IsTemplate { get; } = !Path.Contains<LinkTypeNode>();

        public TypePath Path { get; } = Path.Add<LinkTypeNode>(Entry.Type.ReferenceName);
    }

    public LinkTypeNode(IncrementalGeneratorInitializationContext context, Logger logger) : base(context, logger)
    {
    }

    public TypeSpec CreateSpec(AncestorPathingIntrospection introspection, State state, TypePath path)
    {
        var spec = TypeSpec
            .From(state.Entry.Type)
            .AddModifiers("new")
            .AddBases([
                ..introspection.SemanticBases,
                ..introspection.AncestorBases.Select(x => $"{x.Actor}.{path.FormatRelative()}")
            ]);

        if (state.IsTemplate)
        {
            spec = spec.AddBases(
                $"{state.ActorInfo.Actor}.Link"
            );

            switch (state.ActorInfo.Assembly)
            {
                case ActorsTask.AssemblyTarget.Core:
                    spec = spec.AddBases(
                        $"{state.ActorInfo.FormattedLinkType}.{state.Path.FormatRelative()}"
                    );
                    break;
                case ActorsTask.AssemblyTarget.Rest:
                    spec = spec.AddBases(
                        state.ActorInfo.FormattedRestLinkType
                    );
                    break;
            }
        }

        return spec;
    }

    public IncrementalValuesProvider<NodeGeneration<State, TParent>> Create<TParent>(
        IncrementalValuesProvider<NodeContext<TParent, ActorInfo>> provider,
        ContinuationContext<State, TParent> continuationContext)
    {
        continuationContext.AddChild(GetNode<HierarchyNode>(), x => x.ActorInfo);
        continuationContext.AddChild(GetNode<BackLinkNode>(), x => x.ActorInfo);
        continuationContext.AddChild(GetNode<ExtensionNode>(), x => x.ActorInfo);

        continuationContext.WithImplementationFrom(GetNode<IndexableNode>());
        continuationContext.WithImplementationFrom(GetNode<EnumerableNode>());
        continuationContext.WithImplementationFrom(GetNode<DefinedNode>());
        continuationContext.WithImplementationFrom(GetNode<PagedNode>());

        return provider
            .Combine(Schematics.Collect())
            .SelectMany((tuple, _) => CreateState(tuple.Left, tuple.Right));

        static IEnumerable<NodeGeneration<State, TParent>> CreateState(
            NodeContext<TParent, ActorInfo> context,
            ImmutableArray<LinkSchematics.Schematic> schematics)
        {
            foreach (var schematic in schematics)
            foreach (var entry in schematic.Root.Children)
            {
                yield return CreateLinkState(context, entry, context.Path);
            }
        }

        static NodeGeneration<State, TParent> CreateLinkState(
            NodeContext<TParent, ActorInfo> context,
            LinkSchematics.Entry entry,
            TypePath path)
        {
            var state = new State(
                context.Parameters,
                path,
                entry
            );

            return context.WithState(
                state,
                state.Path,
                entry.Children.Select(child => CreateLinkState(context, child, state.Path))
            );
        }
    }

    // public IncrementalValuesProvider<Branch<TypeSpec>> Create<TSource>(
    //     IncrementalValuesProvider<Branch<(NestedTypeProducerContext Parameters, TSource Source)>> provider)
    // {
    //     var stateProvider = provider
    //         .Select((x, _) => x.Parameters)
    //         .Combine(Schematics.Collect())
    //         .SelectMany((tuple, token) =>
    //             CreateState(
    //                 tuple.Left.Value,
    //                 tuple.Right,
    //                 token
    //             ).Select(x =>
    //                 tuple.Left.Mutate(x)
    //             )
    //         );
    //
    //     var implementationProvider = Branch(
    //             stateProvider,
    //             CreateLinkType,
    //             GetNode<IndexableNode>(),
    //             GetNode<EnumerableNode>(),
    //             GetNode<DefinedNode>(),
    //             GetNode<PagedNode>()
    //         )
    //         .KeyedBy(x => x.Value.State.ActorInfo)
    //         .JoinByKey(
    //             GetTask<ActorsTask>().ActorAncestors,
    //             AddHierarchy
    //         )
    //         .ValuesProvider;
    //
    //     var nestedProvider = AddNestedTypes(
    //         implementationProvider,
    //         (state, _) => new NestedTypeProducerContext(state.ActorInfo, state.Path),
    //         GetNode<BackLinkNode>(),
    //         GetNode<HierarchyNode>(),
    //         GetNode<ExtensionNode>()
    //     );
    //
    //     return NestTypesViaPaths(nestedProvider).Select((x, _) => x.Spec);
    // }

    private StatefulGeneration<State> CreateLinkType(
        State state,
        ImmutableArray<ILinkImplmenter.LinkImplementation> implementations,
        CancellationToken token
    )
    {
        var spec = TypeSpec
            .From(state.Entry.Type)
            .AddModifiers("new");

        foreach (var implementation in implementations)
        {
            implementation.Interface.Apply(ref spec);
        }

        if (state.IsTemplate)
        {
            spec = spec.AddBases(
                $"{state.ActorInfo.Actor}.Link"
            );

            switch (state.ActorInfo.Assembly)
            {
                case ActorsTask.AssemblyTarget.Core:
                    spec = spec.AddBases(
                        $"{state.ActorInfo.FormattedLinkType}.{state.Path.FormatRelative()}"
                    );
                    break;
                case ActorsTask.AssemblyTarget.Rest:
                    spec = spec.AddBases(
                        state.ActorInfo.FormattedRestLinkType
                    );
                    break;
            }
        }
        else if (state.Path.First.HasValue)
        {
            spec = spec.AddBases([..state.Path.First.Value + state.Path.Slice(1).SemanticalProduct()]);
        }

        return new StatefulGeneration<State>(
            state,
            spec
        );
    }

    private static IEnumerable<State> CreateState(
        NestedTypeProducerContext context,
        ImmutableArray<LinkSchematics.Schematic> schematics,
        CancellationToken token
    )
    {
        foreach
        (
            var state in
            from schematic in schematics
            from entry in schematic.Root.Children
            from state in CreateStateForEntry(entry, context.Path)
            select state
        ) yield return state;

        yield break;

        IEnumerable<State> CreateStateForEntry(
            LinkSchematics.Entry entry,
            TypePath path)
        {
            var state = new State(context.ActorInfo, path, entry);

            yield return state;

            foreach (var child in entry.Children)
            foreach (var childState in CreateStateForEntry(child, path.Add<LinkTypeNode>(entry.Type.ReferenceName)))
                yield return childState;
        }
    }

    public IncrementalValuesProvider<IntrospectionResult<AncestorPathingIntrospection, State>> Introspect(
        IncrementalValuesProvider<IntrospectionContext<State>> provider
    ) => Introspect(provider, x => x.ActorInfo);
}