using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IApplicationCommandInteractionMetadataModel : 
    IEquatable<Discord.Models.IApplicationCommandInteractionMetadataModel>
{
    new bool Equals(Discord.Models.IApplicationCommandInteractionMetadataModel? other)
    {
        if(other is null) return false;
        
        return
            (this.TargetUser.IsSpecified == other.TargetUser.IsSpecified) && (!this.TargetUser.IsSpecified || (EqualityComparer<Discord.Models.ModelOrId<Discord.Models.IUserModel, ulong>>.Default.Equals(this.TargetUser.Value, other.TargetUser.Value))) &&
            (this.TargetMessageId.IsSpecified == other.TargetMessageId.IsSpecified) && (!this.TargetMessageId.IsSpecified || (EqualityComparer<ulong>.Default.Equals(this.TargetMessageId.Value, other.TargetMessageId.Value)));
    }
    

    bool IEquatable<Discord.Models.IApplicationCommandInteractionMetadataModel>.Equals(Discord.Models.IApplicationCommandInteractionMetadataModel? other) => Equals(other);
}
