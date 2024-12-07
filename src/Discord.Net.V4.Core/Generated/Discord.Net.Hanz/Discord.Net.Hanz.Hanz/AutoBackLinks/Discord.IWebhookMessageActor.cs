using Discord;

namespace Discord;

public partial interface IWebhookMessageActor
{
    new Discord.IReactionActor.Indexable.BackLink<Discord.IWebhookMessageActor> Reactions { get; }

    Discord.IReactionActor.Indexable.BackLink<Discord.IMessageActor> Discord.IMessageActor.Reactions => Reactions;
}
