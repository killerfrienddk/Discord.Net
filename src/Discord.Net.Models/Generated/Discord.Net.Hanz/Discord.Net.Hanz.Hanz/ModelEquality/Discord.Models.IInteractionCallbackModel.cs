using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IInteractionCallbackModel : 
    IEquatable<Discord.Models.IInteractionCallbackModel>
{
    new bool Equals(Discord.Models.IInteractionCallbackModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<int>.Default.Equals(this.Type, other.Type) &&
            (this.ActivityInstanceId.IsSpecified == other.ActivityInstanceId.IsSpecified) && (!this.ActivityInstanceId.IsSpecified || (EqualityComparer<string>.Default.Equals(this.ActivityInstanceId.Value, other.ActivityInstanceId.Value))) &&
            (this.ResponseMessageId.IsSpecified == other.ResponseMessageId.IsSpecified) && (!this.ResponseMessageId.IsSpecified || (EqualityComparer<ulong>.Default.Equals(this.ResponseMessageId.Value, other.ResponseMessageId.Value))) &&
            (this.ResponseMessageLoading.IsSpecified == other.ResponseMessageLoading.IsSpecified) && (!this.ResponseMessageLoading.IsSpecified || (EqualityComparer<bool>.Default.Equals(this.ResponseMessageLoading.Value, other.ResponseMessageLoading.Value))) &&
            (this.ResponseMessageEphemeral.IsSpecified == other.ResponseMessageEphemeral.IsSpecified) && (!this.ResponseMessageEphemeral.IsSpecified || (EqualityComparer<bool>.Default.Equals(this.ResponseMessageEphemeral.Value, other.ResponseMessageEphemeral.Value)));
    }
    

    bool IEquatable<Discord.Models.IInteractionCallbackModel>.Equals(Discord.Models.IInteractionCallbackModel? other) => Equals(other);
}
