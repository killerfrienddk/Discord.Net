namespace Discord.Models;

[ModelEquality]
public partial interface IIntegrationAccountModel : IEntityModel<string>
{
    string Name { get; }
}