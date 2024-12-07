

namespace Discord.Models;

public partial interface IChannelApplicationCommandOptionModel : IEquatable<IChannelApplicationCommandOptionModel>
{
    new bool Equals(Discord.Models.IChannelApplicationCommandOptionModel? other)
    {
        if (other is null)
            return false;
        return (this.IsRequired?.Equals(this.IsRequired) ?? this.IsRequired is not null) && (this.ChannelTypes?.Equals(this.ChannelTypes) ?? this.ChannelTypes is not null) && this.Type.Equals(this.Type) && this.Name.Equals(this.Name) && (this.NameLocalizations?.Equals(this.NameLocalizations) ?? this.NameLocalizations is not null) && this.Description.Equals(this.Description) && (this.DescriptionLocalizations?.Equals(this.DescriptionLocalizations) ?? this.DescriptionLocalizations is not null);
    }

    bool IEquatable<IChannelApplicationCommandOptionModel>.Equals(IChannelApplicationCommandOptionModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IChannelApplicationCommandOptionModel otherThis && Equals(otherThis);
    bool IApplicationCommandOptionModel.Equals(IApplicationCommandOptionModel? other) => other is IChannelApplicationCommandOptionModel otherThis && Equals(otherThis);
}