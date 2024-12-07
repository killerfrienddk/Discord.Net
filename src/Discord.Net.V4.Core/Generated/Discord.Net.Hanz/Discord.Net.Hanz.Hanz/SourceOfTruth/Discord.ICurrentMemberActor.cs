using Discord.Rest;
using System.Diagnostics.CodeAnalysis;

namespace Discord;

public partial interface ICurrentMemberActor
{
    Discord.IVoiceStateActor IMemberActor.VoiceState => VoiceState;
}
