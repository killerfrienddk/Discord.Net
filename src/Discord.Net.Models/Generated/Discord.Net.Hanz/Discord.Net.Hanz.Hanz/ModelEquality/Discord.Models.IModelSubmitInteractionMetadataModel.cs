using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IModelSubmitInteractionMetadataModel : 
    IEquatable<Discord.Models.IModelSubmitInteractionMetadataModel>
{
    new bool Equals(Discord.Models.IModelSubmitInteractionMetadataModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<Discord.Models.IMessageInteractionMetadataModel>.Default.Equals(this.TriggeringInteractionMetadata, other.TriggeringInteractionMetadata);
    }
    

    bool IEquatable<Discord.Models.IModelSubmitInteractionMetadataModel>.Equals(Discord.Models.IModelSubmitInteractionMetadataModel? other) => Equals(other);
}
