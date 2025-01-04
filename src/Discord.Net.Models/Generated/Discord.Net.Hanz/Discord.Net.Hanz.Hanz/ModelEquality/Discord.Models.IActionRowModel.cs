using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IActionRowModel : 
    IEquatable<Discord.Models.IActionRowModel>
{
    new bool Equals(Discord.Models.IActionRowModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<System.Collections.Generic.IReadOnlyCollection<Discord.Models.IMessageComponentModel>>.Default.Equals(this.Components, other.Components) &&
            EqualityComparer<int>.Default.Equals(this.Type, other.Type);
    }
    

    bool IEquatable<Discord.Models.IActionRowModel>.Equals(Discord.Models.IActionRowModel? other) => Equals(other);

    bool IEquatable<Discord.Models.IMessageComponentModel>.Equals(Discord.Models.IMessageComponentModel? other) => other is Discord.Models.IActionRowModel self && Equals(self);

    bool Discord.Models.IMessageComponentModel.Equals(Discord.Models.IMessageComponentModel? other) => other is Discord.Models.IActionRowModel self && Equals(self);
}
