using Discord.Models;
using Discord;
using MorseCode.ITask;

namespace Discord;

public partial interface ILinkType<out TActor, TId, out TEntity, in TModel>
    where TActor : class, Discord.IActor<TId, TEntity>
    where TId : System.IEquatable<TId>
    where TEntity : class, Discord.IEntity<TId, TModel>
    where TModel : class, Discord.Models.IModel
{
    public partial interface Indexable;

    public partial interface Enumerable
    {
        public partial interface Indexable : 
            Discord.ILinkType<TActor, TId, TEntity, TModel>.Indexable,
            Discord.ILinkType<TActor, TId, TEntity, TModel>.Enumerable;
    }

    public partial interface Defined
    {
        public partial interface Indexable : 
            Discord.ILinkType<TActor, TId, TEntity, TModel>.Indexable,
            Discord.ILinkType<TActor, TId, TEntity, TModel>.Defined;
    
        public partial interface Enumerable : 
            Discord.ILinkType<TActor, TId, TEntity, TModel>.Enumerable,
            Discord.ILinkType<TActor, TId, TEntity, TModel>.Defined
        {
            public partial interface Indexable : 
                Discord.ILinkType<TActor, TId, TEntity, TModel>.Indexable,
                Discord.ILinkType<TActor, TId, TEntity, TModel>.Defined,
                Discord.ILinkType<TActor, TId, TEntity, TModel>.Enumerable;
        }
    }

    public partial interface Paged<out TPaged, in TParams>
        
        where TParams : class, Discord.IPagingParams
    {
        public partial interface Indexable : 
            Discord.ILinkType<TActor, TId, TEntity, TModel>.Indexable,
            Discord.ILinkType<TActor, TId, TEntity, TModel>.Paged<TPaged, TParams>;
    }

    public partial interface Paged<in TParams>
        where TParams : Discord.IPagingParams
    {
        public partial interface Indexable : 
            Discord.ILinkType<TActor, TId, TEntity, TModel>.Indexable,
            Discord.ILinkType<TActor, TId, TEntity, TModel>.Paged<TParams>;
    }
}