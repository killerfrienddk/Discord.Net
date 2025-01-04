using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IVoiceRegionModel : 
    IEquatable<Discord.Models.IVoiceRegionModel>
{
    new bool Equals(Discord.Models.IVoiceRegionModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<string>.Default.Equals(this.Name, other.Name) &&
            EqualityComparer<bool>.Default.Equals(this.IsOptimal, other.IsOptimal) &&
            EqualityComparer<bool>.Default.Equals(this.IsDeprecated, other.IsDeprecated) &&
            EqualityComparer<bool>.Default.Equals(this.IsCustom, other.IsCustom);
    }
    

    bool IEquatable<Discord.Models.IVoiceRegionModel>.Equals(Discord.Models.IVoiceRegionModel? other) => Equals(other);
}
