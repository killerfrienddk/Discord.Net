using Discord.Converters;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace Discord;

//Based on https://github.com/dotnet/coreclr/blob/master/src/mscorlib/src/System/Nullable.cs
[DebuggerDisplay(@"{DebuggerDisplay,nq}")]
[JsonConverter(typeof(OptionalConverter))]
public readonly struct Optional<T> : 
    IEquatable<Optional<T>>
{
    public static readonly Optional<T> Unspecified = default;
    
    public T Value
    {
        get
        {
            if (!IsSpecified)
                throw new InvalidOperationException("This property has no value set.");
            return _value;
        }
    }
    public bool IsSpecified { get; }
    
    private readonly T _value;

    public Optional(T value)
    {
        _value = value;
        IsSpecified = true;
    }

    public bool Equals(Optional<T> other, IEqualityComparer<T> comparer)
    {
        if (IsSpecified != other.IsSpecified)
            return false;
        
        return !IsSpecified || comparer.Equals(Value, other.Value);
    }

    public bool Equals(Optional<T> other)
        => Equals(other, EqualityComparer<T>.Default);

    public override bool Equals([NotNullWhen(true)] object? obj)
        => obj is Optional<T> other && Equals(other);

    public override int GetHashCode()
        => HashCode.Combine(IsSpecified, _value);

    public static implicit operator Optional<T>(T value) => new(value);
    
    public static bool operator ==(Optional<T> left, Optional<T> right) => left.Equals(right);
    public static bool operator !=(Optional<T> left, Optional<T> right) => !left.Equals(right);
    
    public static bool operator true(Optional<T> opt) => opt.IsSpecified;
    public static bool operator false(Optional<T> opt) => !opt.IsSpecified;
}
public static class Optional
{
    public static Optional<T> FromNullable<T>(T? value)
        where T : struct
        => value.HasValue ? Some(value.Value) : Optional<T>.Unspecified;
    public static Optional<T> FromNullable<T>(T? value)
        where T : class?
        => value is null ? Optional<T>.Unspecified : Some<T>(value);
    public static Optional<T> Some<T>() => Optional<T>.Unspecified;
    public static Optional<T> Some<T>(T value) => new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T? ToNullable<T>(this Optional<T> val)
        where T : struct
        => val.IsSpecified ? val.Value : null;
}
