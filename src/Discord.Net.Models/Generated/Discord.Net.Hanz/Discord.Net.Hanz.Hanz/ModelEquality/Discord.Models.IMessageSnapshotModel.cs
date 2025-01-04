using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IMessageSnapshotModel : 
    IEquatable<Discord.Models.IMessageSnapshotModel>
{
    new bool Equals(Discord.Models.IMessageSnapshotModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<Discord.Models.IMessageSnapshotMessageModel>.Default.Equals(this.Message, other.Message);
    }
    

    bool IEquatable<Discord.Models.IMessageSnapshotModel>.Equals(Discord.Models.IMessageSnapshotModel? other) => Equals(other);
}
