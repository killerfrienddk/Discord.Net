using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IActivitySecretsModel : 
    IEquatable<Discord.Models.IActivitySecretsModel>
{
    new bool Equals(Discord.Models.IActivitySecretsModel? other)
    {
        if(other is null) return false;
        
        return
            (this.Join.IsSpecified == other.Join.IsSpecified) && (!this.Join.IsSpecified || (EqualityComparer<string>.Default.Equals(this.Join.Value, other.Join.Value))) &&
            (this.Spectate.IsSpecified == other.Spectate.IsSpecified) && (!this.Spectate.IsSpecified || (EqualityComparer<string>.Default.Equals(this.Spectate.Value, other.Spectate.Value))) &&
            (this.Match.IsSpecified == other.Match.IsSpecified) && (!this.Match.IsSpecified || (EqualityComparer<string>.Default.Equals(this.Match.Value, other.Match.Value)));
    }
    

    bool IEquatable<Discord.Models.IActivitySecretsModel>.Equals(Discord.Models.IActivitySecretsModel? other) => Equals(other);
}
