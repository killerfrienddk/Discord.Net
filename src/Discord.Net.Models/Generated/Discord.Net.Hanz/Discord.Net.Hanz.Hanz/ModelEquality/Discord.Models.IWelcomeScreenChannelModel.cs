using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IWelcomeScreenChannelModel : 
    IEquatable<Discord.Models.IWelcomeScreenChannelModel>
{
    new bool Equals(Discord.Models.IWelcomeScreenChannelModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<ulong>.Default.Equals(this.ChannelId, other.ChannelId) &&
            EqualityComparer<string?>.Default.Equals(this.Description, other.Description) &&
            EqualityComparer<Discord.DiscordEmojiId?>.Default.Equals(this.Emoji, other.Emoji);
    }
    

    bool IEquatable<Discord.Models.IWelcomeScreenChannelModel>.Equals(Discord.Models.IWelcomeScreenChannelModel? other) => Equals(other);
}
