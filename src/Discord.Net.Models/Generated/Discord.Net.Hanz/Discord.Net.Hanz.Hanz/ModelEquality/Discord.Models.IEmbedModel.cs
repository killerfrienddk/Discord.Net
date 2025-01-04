using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IEmbedModel : 
    IEquatable<Discord.Models.IEmbedModel>
{
    new bool Equals(Discord.Models.IEmbedModel? other)
    {
        if(other is null) return false;
        
        return
            (this.Title.IsSpecified == other.Title.IsSpecified) && (!this.Title.IsSpecified || (EqualityComparer<string>.Default.Equals(this.Title.Value, other.Title.Value))) &&
            (this.Type.IsSpecified == other.Type.IsSpecified) && (!this.Type.IsSpecified || (EqualityComparer<string>.Default.Equals(this.Type.Value, other.Type.Value))) &&
            (this.Description.IsSpecified == other.Description.IsSpecified) && (!this.Description.IsSpecified || (EqualityComparer<string>.Default.Equals(this.Description.Value, other.Description.Value))) &&
            (this.Url.IsSpecified == other.Url.IsSpecified) && (!this.Url.IsSpecified || (EqualityComparer<string>.Default.Equals(this.Url.Value, other.Url.Value))) &&
            (this.Timestamp.IsSpecified == other.Timestamp.IsSpecified) && (!this.Timestamp.IsSpecified || (EqualityComparer<System.DateTimeOffset>.Default.Equals(this.Timestamp.Value, other.Timestamp.Value))) &&
            (this.Color.IsSpecified == other.Color.IsSpecified) && (!this.Color.IsSpecified || (EqualityComparer<uint>.Default.Equals(this.Color.Value, other.Color.Value))) &&
            (this.Footer.IsSpecified == other.Footer.IsSpecified) && (!this.Footer.IsSpecified || (EqualityComparer<Discord.Models.IEmbedFooterModel>.Default.Equals(this.Footer.Value, other.Footer.Value))) &&
            (this.Image.IsSpecified == other.Image.IsSpecified) && (!this.Image.IsSpecified || (EqualityComparer<Discord.Models.IEmbedImageModel>.Default.Equals(this.Image.Value, other.Image.Value))) &&
            (this.Thumbnail.IsSpecified == other.Thumbnail.IsSpecified) && (!this.Thumbnail.IsSpecified || (EqualityComparer<Discord.Models.IEmbedThumbnailModel>.Default.Equals(this.Thumbnail.Value, other.Thumbnail.Value))) &&
            (this.Video.IsSpecified == other.Video.IsSpecified) && (!this.Video.IsSpecified || (EqualityComparer<Discord.Models.IEmbedVideoModel>.Default.Equals(this.Video.Value, other.Video.Value))) &&
            (this.Provider.IsSpecified == other.Provider.IsSpecified) && (!this.Provider.IsSpecified || (EqualityComparer<Discord.Models.IEmbedProviderModel>.Default.Equals(this.Provider.Value, other.Provider.Value))) &&
            (this.Author.IsSpecified == other.Author.IsSpecified) && (!this.Author.IsSpecified || (EqualityComparer<Discord.Models.IEmbedAuthorModel>.Default.Equals(this.Author.Value, other.Author.Value))) &&
            (this.Fields.IsSpecified == other.Fields.IsSpecified) && (!this.Fields.IsSpecified || (EqualityComparer<System.Collections.Generic.IReadOnlyCollection<Discord.Models.IEmbedFieldModel>>.Default.Equals(this.Fields.Value, other.Fields.Value)));
    }
    

    bool IEquatable<Discord.Models.IEmbedModel>.Equals(Discord.Models.IEmbedModel? other) => Equals(other);
}
