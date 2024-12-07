using System.Text;
using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Discord.Net.Hanz.Tasks.Actors.Common;

public sealed class RouteInfoGroup : IEquatable<RouteInfoGroup>
{
    public string Name { get; }
    
    public ImmutableEquatableArray<RouteInfo> Routes { get; }

    public RouteInfoGroup(ImmutableEquatableArray<RouteInfo> routes)
    {
        if (routes.Count == 0)
            throw new ArgumentException("No routes");
        
        Routes = routes;
        Name = routes[0].Name;

        if (routes.Any(x => x.Name != Name))
            throw new ArgumentException("Routes have mismatching names");
    }

    private RouteInfoGroup(ImmutableEquatableArray<RouteInfo> routes, string name)
    {
        Name = name;
        Routes = routes;
    }

    public RouteInfoGroup? Refine(Func<RouteInfo, bool> predicate)
    {
        var next = Routes.Where(predicate).ToImmutableEquatableArray();

        if (next.Count == 0) return null;

        return new(next, Name);
    }

    public RouteInfo? BestMatch(Func<RouteInfo, IEnumerable<bool>> predicate)
    {
        if (Routes.Count == 1)
            return Routes[0];
        
        return Routes.OrderByDescending(x => predicate(x).Count(x => x)).FirstOrDefault();
    }
    
    public RouteInfo? BestMatch(Func<RouteInfo, int> predicate)
    {
        if (Routes.Count == 1)
            return Routes[0];
        
        return Routes.OrderByDescending(predicate).FirstOrDefault();
    }
    
    public bool Equals(RouteInfoGroup? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        return Routes.Equals(other.Routes);
    }

    public override bool Equals(object? obj)
    {
        return ReferenceEquals(this, obj) || obj is RouteInfoGroup other && Equals(other);
    }

    public override int GetHashCode()
    {
        return Routes.GetHashCode();
    }
}

public record RouteGenericParameterInfo(
    string Name,
    TypeRef Type,
    ImmutableEquatableArray<TypeRef> TypeConstraints
);

public record RouteInfo(
    string Name,
    string RequestMethod,
    TypeRef? RequestBody,
    TypeRef? ResponseBody,
    string? ContentType,
    ImmutableEquatableArray<RouteParameter> Parameters,
    RouteKind Kind,
    ImmutableEquatableArray<RouteGenericParameterInfo> GenericParameters
)
{
    public string AsInvocation(
        Func<RouteParameter, string?>? resolveParameter = null,
        IEnumerable<string>? generics = null)
    {
        var sb = new StringBuilder();

        sb.Append($"Discord.Rest.Routes.{Name}");

        if (generics is not null)
        {
            var genericsArr = generics.ToArray();

            if (genericsArr.Length > 0)
                sb.Append("<").Append(string.Join(", ", genericsArr)).Append(">");
        }

        if (Kind is RouteKind.Field or RouteKind.Property)
            return sb.ToString();

        sb.Append('(');

        var parameters = new List<string>();

        for (var i = 0; i < Parameters.Count; i++)
        {
            var parameter = Parameters[i];

            var resolved = resolveParameter?.Invoke(parameter);

            if (resolved is null && parameter.Default is not null)
                continue;

            parameters.Add(resolved ?? parameter.Name);
        }

        sb.Append(string.Join(", ", parameters));

        sb.Append(')');

        return sb.ToString();
    }
}

public enum RouteKind
{
    Field,
    Property,
    Method
}

public readonly record struct RouteParameter(
    string Name,
    TypeRef Type,
    ImmutableEquatableArray<TypeRef> Heuristics,
    string? Default = null,
    bool IsGeneric = false
);