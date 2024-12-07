

namespace Discord.Models;

public partial interface IGuildStickerModel : IEquatable<IGuildStickerModel>
{
    new bool Equals(Discord.Models.IGuildStickerModel? other)
    {
        if (other is null)
            return false;
        return (this.Available?.Equals(this.Available) ?? this.Available is not null) && this.GuildId.Equals(this.GuildId) && (this.AuthorId?.Equals(this.AuthorId) ?? this.AuthorId is not null) && (this.PackId?.Equals(this.PackId) ?? this.PackId is not null) && this.Name.Equals(this.Name) && (this.Description?.Equals(this.Description) ?? this.Description is not null) && this.Tags.Equals(this.Tags) && this.Type.Equals(this.Type) && this.FormatType.Equals(this.FormatType) && (this.SortValue?.Equals(this.SortValue) ?? this.SortValue is not null);
    }

    bool IEquatable<IGuildStickerModel>.Equals(IGuildStickerModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IGuildStickerModel otherThis && Equals(otherThis);
    bool IStickerModel.Equals(IStickerModel? other) => other is IGuildStickerModel otherThis && Equals(otherThis);
}