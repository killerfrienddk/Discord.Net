using System.Diagnostics.CodeAnalysis;

namespace Discord.Models;

public interface IPartialModel<in T> : IPartialModel
{
    bool ApplyTo(T model);
}

public interface IPartialModel : IModel
{
    Type UnderlyingModelType { get; }
    
    bool TryGet<U>(string property, [MaybeNullWhen(false)] out U value);

    bool Has(string property);
}