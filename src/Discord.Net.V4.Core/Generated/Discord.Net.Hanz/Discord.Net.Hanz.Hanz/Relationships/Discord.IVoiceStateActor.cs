using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IVoiceStateActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IVoiceStateActor, ulong, Discord.IVoiceState>
    {
        Discord.IVoiceStateActor VoiceState { get; }
    
        Discord.IVoiceStateActor Discord.IRelationship<Discord.IVoiceStateActor, ulong, Discord.IVoiceState>.RelationshipActor => VoiceState;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IVoiceStateActor, ulong, Discord.IVoiceState>
    {
        new Discord.IMemberActor Member => VoiceState.Member;
    
        new Discord.IGuildActor Guild => VoiceState.Member.Guild;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
