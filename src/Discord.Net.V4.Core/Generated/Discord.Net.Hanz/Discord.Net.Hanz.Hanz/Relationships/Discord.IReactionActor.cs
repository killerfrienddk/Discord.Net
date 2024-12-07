using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IReactionActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IReactionActor, Discord.DiscordEmojiId, Discord.IReaction>
    {
        Discord.IReactionActor Reaction { get; }
    
        Discord.IReactionActor Discord.IRelationship<Discord.IReactionActor, Discord.DiscordEmojiId, Discord.IReaction>.RelationshipActor => Reaction;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IReactionActor, Discord.DiscordEmojiId, Discord.IReaction>
    {
        new Discord.IMessageActor Message => Reaction.Message;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
