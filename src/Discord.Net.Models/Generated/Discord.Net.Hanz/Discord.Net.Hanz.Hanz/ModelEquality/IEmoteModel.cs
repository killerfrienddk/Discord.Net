using Discord.Converters;
using System.Text.Json.Serialization;

namespace Discord.Models;

public partial interface IEmoteModel : IEquatable<IEmoteModel>
{
    new bool Equals(Discord.Models.IEmoteModel? other)
    {
        if (other is null)
            return false;
        return this.Name.Equals(this.Name);
    }

    bool IEquatable<IEmoteModel>.Equals(IEmoteModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IEmoteModel otherThis && Equals(otherThis);
}