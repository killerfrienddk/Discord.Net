using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface ITagModel : 
    IEquatable<Discord.Models.ITagModel>
{
    new bool Equals(Discord.Models.ITagModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<string>.Default.Equals(this.Name, other.Name) &&
            EqualityComparer<bool>.Default.Equals(this.Moderated, other.Moderated) &&
            (this.Emoji.IsSpecified == other.Emoji.IsSpecified) && (!this.Emoji.IsSpecified || (EqualityComparer<Discord.DiscordEmojiId>.Default.Equals(this.Emoji.Value, other.Emoji.Value)));
    }
    

    bool IEquatable<Discord.Models.ITagModel>.Equals(Discord.Models.ITagModel? other) => Equals(other);
}
