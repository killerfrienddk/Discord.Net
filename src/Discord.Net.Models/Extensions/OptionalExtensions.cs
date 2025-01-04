namespace Discord;

public static class OptionalExtensions
{
    public static Optional<T> Some<T>(this T value) => Optional.Some(value);
    
    public static Optional<U> Map<T, U>(this Optional<T> optional, Func<T, U> mapper)
        => optional.IsSpecified ? mapper(optional.Value).Some() : default;
}