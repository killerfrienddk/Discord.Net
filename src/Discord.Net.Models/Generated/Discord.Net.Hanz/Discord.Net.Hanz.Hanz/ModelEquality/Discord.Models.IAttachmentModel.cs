using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IAttachmentModel : 
    IEquatable<Discord.Models.IAttachmentModel>
{
    new bool Equals(Discord.Models.IAttachmentModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<string>.Default.Equals(this.Filename, other.Filename) &&
            (this.Title.IsSpecified == other.Title.IsSpecified) && (!this.Title.IsSpecified || (EqualityComparer<string>.Default.Equals(this.Title.Value, other.Title.Value))) &&
            (this.Description.IsSpecified == other.Description.IsSpecified) && (!this.Description.IsSpecified || (EqualityComparer<string>.Default.Equals(this.Description.Value, other.Description.Value))) &&
            (this.ContentType.IsSpecified == other.ContentType.IsSpecified) && (!this.ContentType.IsSpecified || (EqualityComparer<string>.Default.Equals(this.ContentType.Value, other.ContentType.Value))) &&
            EqualityComparer<int>.Default.Equals(this.Size, other.Size) &&
            EqualityComparer<string>.Default.Equals(this.Url, other.Url) &&
            EqualityComparer<string>.Default.Equals(this.ProxyUrl, other.ProxyUrl) &&
            (this.Height.IsSpecified == other.Height.IsSpecified) && (!this.Height.IsSpecified || (EqualityComparer<int?>.Default.Equals(this.Height.Value, other.Height.Value))) &&
            (this.Width.IsSpecified == other.Width.IsSpecified) && (!this.Width.IsSpecified || (EqualityComparer<int?>.Default.Equals(this.Width.Value, other.Width.Value))) &&
            (this.Ephemeral.IsSpecified == other.Ephemeral.IsSpecified) && (!this.Ephemeral.IsSpecified || (EqualityComparer<bool>.Default.Equals(this.Ephemeral.Value, other.Ephemeral.Value))) &&
            (this.Duration.IsSpecified == other.Duration.IsSpecified) && (!this.Duration.IsSpecified || (EqualityComparer<System.TimeSpan>.Default.Equals(this.Duration.Value, other.Duration.Value))) &&
            (this.Waveform.IsSpecified == other.Waveform.IsSpecified) && (!this.Waveform.IsSpecified || (EqualityComparer<string>.Default.Equals(this.Waveform.Value, other.Waveform.Value))) &&
            (this.Flags.IsSpecified == other.Flags.IsSpecified) && (!this.Flags.IsSpecified || (EqualityComparer<int>.Default.Equals(this.Flags.Value, other.Flags.Value)));
    }
    

    bool IEquatable<Discord.Models.IAttachmentModel>.Equals(Discord.Models.IAttachmentModel? other) => Equals(other);
}
