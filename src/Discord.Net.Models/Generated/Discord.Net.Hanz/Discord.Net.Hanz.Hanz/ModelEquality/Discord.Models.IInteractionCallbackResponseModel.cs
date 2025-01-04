using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IInteractionCallbackResponseModel : 
    IEquatable<Discord.Models.IInteractionCallbackResponseModel>
{
    new bool Equals(Discord.Models.IInteractionCallbackResponseModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<Discord.Models.IInteractionCallbackModel>.Default.Equals(this.Interaction, other.Interaction) &&
            (this.Resource.IsSpecified == other.Resource.IsSpecified) && (!this.Resource.IsSpecified || (EqualityComparer<Discord.Models.IInteractionCallbackResourceModel>.Default.Equals(this.Resource.Value, other.Resource.Value)));
    }
    

    bool IEquatable<Discord.Models.IInteractionCallbackResponseModel>.Equals(Discord.Models.IInteractionCallbackResponseModel? other) => Equals(other);
}
