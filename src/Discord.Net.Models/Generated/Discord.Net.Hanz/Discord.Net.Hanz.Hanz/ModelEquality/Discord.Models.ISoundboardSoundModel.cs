using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface ISoundboardSoundModel : 
    IEquatable<Discord.Models.ISoundboardSoundModel>
{
    new bool Equals(Discord.Models.ISoundboardSoundModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<string>.Default.Equals(this.Name, other.Name) &&
            EqualityComparer<double>.Default.Equals(this.Volume, other.Volume) &&
            (this.Emoji.IsSpecified == other.Emoji.IsSpecified) && (!this.Emoji.IsSpecified || (EqualityComparer<Discord.DiscordEmojiId>.Default.Equals(this.Emoji.Value, other.Emoji.Value))) &&
            EqualityComparer<bool>.Default.Equals(this.IsAvailable, other.IsAvailable);
    }
    

    bool IEquatable<Discord.Models.ISoundboardSoundModel>.Equals(Discord.Models.ISoundboardSoundModel? other) => Equals(other);
}
