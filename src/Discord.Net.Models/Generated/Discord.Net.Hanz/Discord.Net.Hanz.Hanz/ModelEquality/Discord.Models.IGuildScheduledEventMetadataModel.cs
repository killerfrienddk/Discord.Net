using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IGuildScheduledEventMetadataModel : 
    IEquatable<Discord.Models.IGuildScheduledEventMetadataModel>
{
    new bool Equals(Discord.Models.IGuildScheduledEventMetadataModel? other)
    {
        if(other is null) return false;
        
        return
            (this.Location.IsSpecified == other.Location.IsSpecified) && (!this.Location.IsSpecified || (EqualityComparer<string>.Default.Equals(this.Location.Value, other.Location.Value)));
    }
    

    bool IEquatable<Discord.Models.IGuildScheduledEventMetadataModel>.Equals(Discord.Models.IGuildScheduledEventMetadataModel? other) => Equals(other);
}
