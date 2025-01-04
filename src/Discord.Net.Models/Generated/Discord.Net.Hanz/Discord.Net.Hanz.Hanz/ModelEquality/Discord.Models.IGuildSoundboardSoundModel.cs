using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IGuildSoundboardSoundModel : 
    IEquatable<Discord.Models.IGuildSoundboardSoundModel>
{
    new bool Equals(Discord.Models.IGuildSoundboardSoundModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<ulong>.Default.Equals(this.GuildId, other.GuildId) &&
            (this.User.IsSpecified == other.User.IsSpecified) && (!this.User.IsSpecified || (EqualityComparer<Discord.Models.ModelOrId<Discord.Models.IUserModel, ulong>>.Default.Equals(this.User.Value, other.User.Value))) &&
            EqualityComparer<string>.Default.Equals(this.Name, other.Name) &&
            EqualityComparer<double>.Default.Equals(this.Volume, other.Volume) &&
            (this.Emoji.IsSpecified == other.Emoji.IsSpecified) && (!this.Emoji.IsSpecified || (EqualityComparer<Discord.DiscordEmojiId>.Default.Equals(this.Emoji.Value, other.Emoji.Value))) &&
            EqualityComparer<bool>.Default.Equals(this.IsAvailable, other.IsAvailable);
    }
    

    bool IEquatable<Discord.Models.IGuildSoundboardSoundModel>.Equals(Discord.Models.IGuildSoundboardSoundModel? other) => Equals(other);

    bool IEquatable<Discord.Models.ISoundboardSoundModel>.Equals(Discord.Models.ISoundboardSoundModel? other) => other is Discord.Models.IGuildSoundboardSoundModel self && Equals(self);

    bool Discord.Models.ISoundboardSoundModel.Equals(Discord.Models.ISoundboardSoundModel? other) => other is Discord.Models.IGuildSoundboardSoundModel self && Equals(self);
}
