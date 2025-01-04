using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IEmojiModel : 
    IEquatable<Discord.Models.IEmojiModel>
{
    new bool Equals(Discord.Models.IEmojiModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<string>.Default.Equals(this.Name, other.Name);
    }
    

    bool IEquatable<Discord.Models.IEmojiModel>.Equals(Discord.Models.IEmojiModel? other) => Equals(other);

    bool IEquatable<Discord.Models.IEmoteModel>.Equals(Discord.Models.IEmoteModel? other) => other is Discord.Models.IEmojiModel self && Equals(self);

    bool Discord.Models.IEmoteModel.Equals(Discord.Models.IEmoteModel? other) => other is Discord.Models.IEmojiModel self && Equals(self);
}
