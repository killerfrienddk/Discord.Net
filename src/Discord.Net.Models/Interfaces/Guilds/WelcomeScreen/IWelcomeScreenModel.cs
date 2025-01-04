namespace Discord.Models;

[ModelEquality]
public partial interface IWelcomeScreenModel : IModel
{
    string? Description { get; }
    IReadOnlyCollection<IWelcomeScreenChannelModel> WelcomeChannels { get; }
}