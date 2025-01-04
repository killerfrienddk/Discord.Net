using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IMessageComponentModel : 
    IEquatable<Discord.Models.IMessageComponentModel>
{
    new bool Equals(Discord.Models.IMessageComponentModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<int>.Default.Equals(this.Type, other.Type);
    }
    

    bool IEquatable<Discord.Models.IMessageComponentModel>.Equals(Discord.Models.IMessageComponentModel? other) => Equals(other);
}
