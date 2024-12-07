using Discord;

namespace Discord;

#pragma warning disable CS0108
#pragma warning disable CS0109
public partial interface IApplicationActor
{
    public interface Relationship : 
        Discord.IRelationship<Discord.IApplicationActor, ulong, Discord.IApplication>
    {
        Discord.IApplicationActor Application { get; }
    
        Discord.IApplicationActor Discord.IRelationship<Discord.IApplicationActor, ulong, Discord.IApplication>.RelationshipActor => Application;
    }

    public interface CanonicalRelationship : 
        Relationship,
        Discord.ICanonicalRelationship<Discord.IApplicationActor, ulong, Discord.IApplication>;
}
#pragma warning restore CS0108
#pragma warning restore CS0109
