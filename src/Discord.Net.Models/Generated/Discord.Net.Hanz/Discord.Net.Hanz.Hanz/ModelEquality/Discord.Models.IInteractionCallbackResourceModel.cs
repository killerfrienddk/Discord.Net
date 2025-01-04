using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IInteractionCallbackResourceModel : 
    IEquatable<Discord.Models.IInteractionCallbackResourceModel>
{
    new bool Equals(Discord.Models.IInteractionCallbackResourceModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<int>.Default.Equals(this.Type, other.Type) &&
            (this.ActivityInstance.IsSpecified == other.ActivityInstance.IsSpecified) && (!this.ActivityInstance.IsSpecified || (EqualityComparer<Discord.Models.IActivityInstanceModel>.Default.Equals(this.ActivityInstance.Value, other.ActivityInstance.Value))) &&
            (this.Message.IsSpecified == other.Message.IsSpecified) && (!this.Message.IsSpecified || (EqualityComparer<Discord.Models.ModelOrId<Discord.Models.IMessageModel, ulong>>.Default.Equals(this.Message.Value, other.Message.Value)));
    }
    

    bool IEquatable<Discord.Models.IInteractionCallbackResourceModel>.Equals(Discord.Models.IInteractionCallbackResourceModel? other) => Equals(other);
}
