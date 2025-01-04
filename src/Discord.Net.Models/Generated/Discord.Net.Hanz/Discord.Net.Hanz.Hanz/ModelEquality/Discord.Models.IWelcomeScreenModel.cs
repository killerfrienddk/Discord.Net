using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IWelcomeScreenModel : 
    IEquatable<Discord.Models.IWelcomeScreenModel>
{
    new bool Equals(Discord.Models.IWelcomeScreenModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<string?>.Default.Equals(this.Description, other.Description) &&
            EqualityComparer<System.Collections.Generic.IReadOnlyCollection<Discord.Models.IWelcomeScreenChannelModel>>.Default.Equals(this.WelcomeChannels, other.WelcomeChannels);
    }
    

    bool IEquatable<Discord.Models.IWelcomeScreenModel>.Equals(Discord.Models.IWelcomeScreenModel? other) => Equals(other);
}
