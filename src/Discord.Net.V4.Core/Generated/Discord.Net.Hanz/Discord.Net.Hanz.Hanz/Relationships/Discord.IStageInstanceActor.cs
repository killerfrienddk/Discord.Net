using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IStageInstanceActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IStageInstanceActor, ulong, Discord.IStageInstance>
    {
        Discord.IStageInstanceActor StageInstance { get; }
    
        Discord.IStageInstanceActor Discord.IRelationship<Discord.IStageInstanceActor, ulong, Discord.IStageInstance>.RelationshipActor => StageInstance;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IStageInstanceActor, ulong, Discord.IStageInstance>
    {
        new Discord.IStageChannelActor Channel => StageInstance.Channel;
    }
}
#pragma warning restore CS0108
#pragma warning restore CS0109
