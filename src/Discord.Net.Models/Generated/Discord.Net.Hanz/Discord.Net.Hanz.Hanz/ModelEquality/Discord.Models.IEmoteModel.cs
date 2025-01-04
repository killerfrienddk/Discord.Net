using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IEmoteModel : 
    IEquatable<Discord.Models.IEmoteModel>
{
    new bool Equals(Discord.Models.IEmoteModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<string>.Default.Equals(this.Name, other.Name);
    }
    

    bool IEquatable<Discord.Models.IEmoteModel>.Equals(Discord.Models.IEmoteModel? other) => Equals(other);
}
