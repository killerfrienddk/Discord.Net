using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IIntegrationAccountModel : 
    IEquatable<Discord.Models.IIntegrationAccountModel>
{
    new bool Equals(Discord.Models.IIntegrationAccountModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<string>.Default.Equals(this.Name, other.Name);
    }
    

    bool IEquatable<Discord.Models.IIntegrationAccountModel>.Equals(Discord.Models.IIntegrationAccountModel? other) => Equals(other);
}
