

namespace Discord.Models;

public partial interface IPrimaryEntryPointApplicationCommandModel : IEquatable<IPrimaryEntryPointApplicationCommandModel>
{
    new bool Equals(Discord.Models.IPrimaryEntryPointApplicationCommandModel? other)
    {
        if (other is null)
            return false;
        return (this.Handler?.Equals(this.Handler) ?? this.Handler is not null) && (this.Type?.Equals(this.Type) ?? this.Type is not null) && this.ApplicationId.Equals(this.ApplicationId) && (this.GuildId?.Equals(this.GuildId) ?? this.GuildId is not null) && this.Name.Equals(this.Name) && (this.NameLocalization?.Equals(this.NameLocalization) ?? this.NameLocalization is not null) && this.Description.Equals(this.Description) && (this.DescriptionLocalization?.Equals(this.DescriptionLocalization) ?? this.DescriptionLocalization is not null) && (this.DefaultMemberPermissions?.Equals(this.DefaultMemberPermissions) ?? this.DefaultMemberPermissions is not null) && (this.IsNsfw?.Equals(this.IsNsfw) ?? this.IsNsfw is not null) && (this.IntegrationTypes?.Equals(this.IntegrationTypes) ?? this.IntegrationTypes is not null) && (this.Contexts?.Equals(this.Contexts) ?? this.Contexts is not null) && this.Version.Equals(this.Version);
    }

    bool IEquatable<IPrimaryEntryPointApplicationCommandModel>.Equals(IPrimaryEntryPointApplicationCommandModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IPrimaryEntryPointApplicationCommandModel otherThis && Equals(otherThis);
    bool IApplicationCommandModel.Equals(IApplicationCommandModel? other) => other is IPrimaryEntryPointApplicationCommandModel otherThis && Equals(otherThis);
}