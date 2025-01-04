using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IModalDataModel : 
    IEquatable<Discord.Models.IModalDataModel>
{
    new bool Equals(Discord.Models.IModalDataModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<string>.Default.Equals(this.CustomId, other.CustomId) &&
            EqualityComparer<System.Collections.Generic.IReadOnlyCollection<Discord.Models.IMessageComponentModel>>.Default.Equals(this.Components, other.Components);
    }
    

    bool IEquatable<Discord.Models.IModalDataModel>.Equals(Discord.Models.IModalDataModel? other) => Equals(other);
}
