using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface ICurrentUserVoiceStateActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.ICurrentUserVoiceStateActor, ulong, Discord.ICurrentUserVoiceState>
    {
        Discord.ICurrentUserVoiceStateActor CurrentUserVoiceState { get; }
    
        Discord.ICurrentUserVoiceStateActor Discord.IRelationship<Discord.ICurrentUserVoiceStateActor, ulong, Discord.ICurrentUserVoiceState>.RelationshipActor => CurrentUserVoiceState;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.ICurrentUserVoiceStateActor, ulong, Discord.ICurrentUserVoiceState>,
        Discord.IVoiceStateActor.CanonicalRelationship
    {
        Discord.IVoiceStateActor Discord.IVoiceStateActor.Relationship.VoiceState => CurrentUserVoiceState;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
