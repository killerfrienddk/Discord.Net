using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface ISoundboardSoundActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.ISoundboardSoundActor, ulong, Discord.ISoundboardSound>
    {
        Discord.ISoundboardSoundActor SoundboardSound { get; }
    
        Discord.ISoundboardSoundActor Discord.IRelationship<Discord.ISoundboardSoundActor, ulong, Discord.ISoundboardSound>.RelationshipActor => SoundboardSound;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.ISoundboardSoundActor, ulong, Discord.ISoundboardSound>;
}
#pragma warning restore CS0108
#pragma warning restore CS0109
