using Microsoft.CodeAnalysis;

namespace Discord.Net.Hanz.Tasks.Actors.TraitsV2.Nodes.Modifiable;

public sealed class ModifiableTraitNode : TraitNode
{
    public ModifiableTraitNode(IncrementalGeneratorInitializationContext context, Logger logger) : base(context, logger)
    {
    }
}