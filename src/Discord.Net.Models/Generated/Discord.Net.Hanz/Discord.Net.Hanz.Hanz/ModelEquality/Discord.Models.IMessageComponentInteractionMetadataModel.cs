using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IMessageComponentInteractionMetadataModel : 
    IEquatable<Discord.Models.IMessageComponentInteractionMetadataModel>
{
    new bool Equals(Discord.Models.IMessageComponentInteractionMetadataModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<ulong>.Default.Equals(this.InteractedMessageId, other.InteractedMessageId);
    }
    

    bool IEquatable<Discord.Models.IMessageComponentInteractionMetadataModel>.Equals(Discord.Models.IMessageComponentInteractionMetadataModel? other) => Equals(other);
}
