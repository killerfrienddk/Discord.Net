

namespace Discord.Models;

public partial interface IGuildTemplateModel : IEquatable<IGuildTemplateModel>
{
    new bool Equals(Discord.Models.IGuildTemplateModel? other)
    {
        if (other is null)
            return false;
        return this.Name.Equals(this.Name) && (this.Description?.Equals(this.Description) ?? this.Description is not null) && this.UsageCount.Equals(this.UsageCount) && this.CreatorId.Equals(this.CreatorId) && this.CreatedAt.Equals(this.CreatedAt) && this.UpdatedAt.Equals(this.UpdatedAt) && this.SourceGuildId.Equals(this.SourceGuildId) && (this.IsDirty?.Equals(this.IsDirty) ?? this.IsDirty is not null);
    }

    bool IEquatable<IGuildTemplateModel>.Equals(IGuildTemplateModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IGuildTemplateModel otherThis && Equals(otherThis);
}