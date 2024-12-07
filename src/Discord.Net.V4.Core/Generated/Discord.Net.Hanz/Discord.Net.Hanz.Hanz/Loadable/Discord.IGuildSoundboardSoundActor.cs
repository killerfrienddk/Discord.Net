using Discord;
using Discord.Models;
using Discord.Rest;

namespace Discord;

public partial interface IGuildSoundboardSoundActor : 
    Discord.ILoadable<Discord.IGuildSoundboardSoundActor, ulong, Discord.IGuildSoundboardSound, Discord.Models.IGuildSoundboardSoundModel>;
