

namespace Discord.Models;

public partial interface IStickerModel : IEquatable<IStickerModel>
{
    new bool Equals(Discord.Models.IStickerModel? other)
    {
        if (other is null)
            return false;
        return (this.PackId?.Equals(this.PackId) ?? this.PackId is not null) && this.Name.Equals(this.Name) && (this.Description?.Equals(this.Description) ?? this.Description is not null) && this.Tags.Equals(this.Tags) && this.Type.Equals(this.Type) && this.FormatType.Equals(this.FormatType) && (this.SortValue?.Equals(this.SortValue) ?? this.SortValue is not null);
    }

    bool IEquatable<IStickerModel>.Equals(IStickerModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IStickerModel otherThis && Equals(otherThis);
}