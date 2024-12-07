

namespace Discord.Models;

public partial interface IStickerItemModel : IEquatable<IStickerItemModel>
{
    new bool Equals(Discord.Models.IStickerItemModel? other)
    {
        if (other is null)
            return false;
        return this.Name.Equals(this.Name) && this.FormatType.Equals(this.FormatType);
    }

    bool IEquatable<IStickerItemModel>.Equals(IStickerItemModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IStickerItemModel otherThis && Equals(otherThis);
}