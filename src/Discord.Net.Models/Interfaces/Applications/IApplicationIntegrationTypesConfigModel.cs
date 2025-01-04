namespace Discord.Models;

public interface IApplicationIntegrationTypesConfigModel
{
    Optional<IApplicationIntegrationTypeConfigurationModel> GuildInstall { get; }
    Optional<IApplicationIntegrationTypeConfigurationModel> UserInstall { get; }
}