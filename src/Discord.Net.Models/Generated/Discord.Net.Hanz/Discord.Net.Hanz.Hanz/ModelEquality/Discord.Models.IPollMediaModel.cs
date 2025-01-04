using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IPollMediaModel : 
    IEquatable<Discord.Models.IPollMediaModel>
{
    new bool Equals(Discord.Models.IPollMediaModel? other)
    {
        if(other is null) return false;
        
        return
            (this.Text.IsSpecified == other.Text.IsSpecified) && (!this.Text.IsSpecified || (EqualityComparer<string>.Default.Equals(this.Text.Value, other.Text.Value))) &&
            (this.Emoji.IsSpecified == other.Emoji.IsSpecified) && (!this.Emoji.IsSpecified || (EqualityComparer<Discord.DiscordEmojiId>.Default.Equals(this.Emoji.Value, other.Emoji.Value)));
    }
    

    bool IEquatable<Discord.Models.IPollMediaModel>.Equals(Discord.Models.IPollMediaModel? other) => Equals(other);
}
