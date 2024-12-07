using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IPollAnswerActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IPollAnswerActor, int, Discord.IPollAnswer>
    {
        Discord.IPollAnswerActor PollAnswer { get; }
    
        Discord.IPollAnswerActor Discord.IRelationship<Discord.IPollAnswerActor, int, Discord.IPollAnswer>.RelationshipActor => PollAnswer;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IPollAnswerActor, int, Discord.IPollAnswer>
    {
        new Discord.IPollActor Poll => PollAnswer.Poll;
    
        new Discord.IMessageActor Message => PollAnswer.Poll.Message;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
