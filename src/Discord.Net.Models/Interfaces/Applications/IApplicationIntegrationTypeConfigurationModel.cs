namespace Discord.Models;

public interface IApplicationIntegrationTypeConfigurationModel
{
    Optional<IApplicationInstallParamsModel> OAuth2InstallParams { get; }
}