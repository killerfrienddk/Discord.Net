using System.Diagnostics.CodeAnalysis;

namespace Discord.Models;

public readonly struct ModelOrId<TModel, TId> :
    IEquatable<ModelOrId<TModel, TId>>
    where TModel : IEntityModel<TId>
    where TId : IEquatable<TId>
{
    public TId Id { get; }
    public Optional<TModel> Model { get; }

    public ModelOrId(TId id)
    {
        Id = id;
        Model = default;
    }

    public ModelOrId(TModel model)
    {
        Model = model;
        Id = model.Id;
    }

    public bool Equals(ModelOrId<TModel, TId> other)
    {
        if (Model.IsSpecified != other.Model.IsSpecified)
            return false;

        if (Model.IsSpecified && other.Model.IsSpecified &&
            !EqualityComparer<TModel>.Default.Equals(Model.Value, other.Model.Value))
            return false;

        return EqualityComparer<TId>.Default.Equals(Id, other.Id);
    }

    public override bool Equals([NotNullWhen(true)] object? obj)
        => obj is ModelOrId<TModel, TId> other && Equals(other);

    public override int GetHashCode()
        => HashCode.Combine(Id, Model);

    public static bool operator ==(ModelOrId<TModel, TId> left, ModelOrId<TModel, TId> right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(ModelOrId<TModel, TId> left, ModelOrId<TModel, TId> right)
    {
        return !(left == right);
    }

    public static implicit operator ModelOrId<TModel, TId>(TModel model) => new(model);
    public static implicit operator ModelOrId<TModel, TId>(TId id) => new(id);
}