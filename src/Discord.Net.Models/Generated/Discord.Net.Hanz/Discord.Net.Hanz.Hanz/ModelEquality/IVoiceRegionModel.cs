

namespace Discord.Models;

public partial interface IVoiceRegionModel : IEquatable<IVoiceRegionModel>
{
    new bool Equals(Discord.Models.IVoiceRegionModel? other)
    {
        if (other is null)
            return false;
        return this.Name.Equals(this.Name) && this.IsOptimal.Equals(this.IsOptimal) && this.IsDeprecated.Equals(this.IsDeprecated) && this.IsCustom.Equals(this.IsCustom);
    }

    bool IEquatable<IVoiceRegionModel>.Equals(IVoiceRegionModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IVoiceRegionModel otherThis && Equals(otherThis);
}