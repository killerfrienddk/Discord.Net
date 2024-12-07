

namespace Discord.Models;

public partial interface IGuildApplicationCommandPermissionsModel : IEquatable<IGuildApplicationCommandPermissionsModel>
{
    new bool Equals(Discord.Models.IGuildApplicationCommandPermissionsModel? other)
    {
        if (other is null)
            return false;
        return this.ApplicationId.Equals(this.ApplicationId) && this.GuildId.Equals(this.GuildId) && this.Permissions.Equals(this.Permissions);
    }

    bool IEquatable<IGuildApplicationCommandPermissionsModel>.Equals(IGuildApplicationCommandPermissionsModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IGuildApplicationCommandPermissionsModel otherThis && Equals(otherThis);
}