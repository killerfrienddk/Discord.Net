using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IIntegrationApplicationModel : 
    IEquatable<Discord.Models.IIntegrationApplicationModel>
{
    new bool Equals(Discord.Models.IIntegrationApplicationModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<string>.Default.Equals(this.Name, other.Name) &&
            EqualityComparer<string?>.Default.Equals(this.Icon, other.Icon) &&
            EqualityComparer<string>.Default.Equals(this.Description, other.Description) &&
            (this.Bot.IsSpecified == other.Bot.IsSpecified) && (!this.Bot.IsSpecified || (EqualityComparer<Discord.Models.ModelOrId<Discord.Models.IUserModel, ulong>>.Default.Equals(this.Bot.Value, other.Bot.Value)));
    }
    

    bool IEquatable<Discord.Models.IIntegrationApplicationModel>.Equals(Discord.Models.IIntegrationApplicationModel? other) => Equals(other);
}
