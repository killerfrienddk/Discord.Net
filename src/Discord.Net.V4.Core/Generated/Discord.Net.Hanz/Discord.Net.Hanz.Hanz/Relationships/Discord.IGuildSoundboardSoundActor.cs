using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IGuildSoundboardSoundActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IGuildSoundboardSoundActor, ulong, Discord.IGuildSoundboardSound>
    {
        Discord.IGuildSoundboardSoundActor GuildSoundboardSound { get; }
    
        Discord.IGuildSoundboardSoundActor Discord.IRelationship<Discord.IGuildSoundboardSoundActor, ulong, Discord.IGuildSoundboardSound>.RelationshipActor => GuildSoundboardSound;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IGuildSoundboardSoundActor, ulong, Discord.IGuildSoundboardSound>,
        Discord.ISoundboardSoundActor.CanonicalRelationship
    {
        new Discord.IGuildActor Guild => GuildSoundboardSound.Guild;
    
        Discord.ISoundboardSoundActor Discord.ISoundboardSoundActor.Relationship.SoundboardSound => GuildSoundboardSound;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
