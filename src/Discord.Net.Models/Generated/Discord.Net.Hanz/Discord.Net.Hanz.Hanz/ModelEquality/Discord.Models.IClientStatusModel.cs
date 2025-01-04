using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IClientStatusModel : 
    IEquatable<Discord.Models.IClientStatusModel>
{
    new bool Equals(Discord.Models.IClientStatusModel? other)
    {
        if(other is null) return false;
        
        return
            (this.Desktop.IsSpecified == other.Desktop.IsSpecified) && (!this.Desktop.IsSpecified || (EqualityComparer<string>.Default.Equals(this.Desktop.Value, other.Desktop.Value))) &&
            (this.Mobile.IsSpecified == other.Mobile.IsSpecified) && (!this.Mobile.IsSpecified || (EqualityComparer<string>.Default.Equals(this.Mobile.Value, other.Mobile.Value))) &&
            (this.Web.IsSpecified == other.Web.IsSpecified) && (!this.Web.IsSpecified || (EqualityComparer<string>.Default.Equals(this.Web.Value, other.Web.Value)));
    }
    

    bool IEquatable<Discord.Models.IClientStatusModel>.Equals(Discord.Models.IClientStatusModel? other) => Equals(other);
}
