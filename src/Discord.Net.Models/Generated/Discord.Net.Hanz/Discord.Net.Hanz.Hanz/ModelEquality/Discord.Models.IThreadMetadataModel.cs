using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IThreadMetadataModel : 
    IEquatable<Discord.Models.IThreadMetadataModel>
{
    new bool Equals(Discord.Models.IThreadMetadataModel? other)
    {
        if(other is null) return false;
        
        return
            EqualityComparer<bool>.Default.Equals(this.IsArchived, other.IsArchived) &&
            EqualityComparer<int>.Default.Equals(this.AutoArchiveDuration, other.AutoArchiveDuration) &&
            EqualityComparer<System.DateTimeOffset>.Default.Equals(this.ArchiveTimestamp, other.ArchiveTimestamp) &&
            EqualityComparer<bool>.Default.Equals(this.IsLocked, other.IsLocked) &&
            (this.IsInvitable.IsSpecified == other.IsInvitable.IsSpecified) && (!this.IsInvitable.IsSpecified || (EqualityComparer<bool>.Default.Equals(this.IsInvitable.Value, other.IsInvitable.Value))) &&
            (this.CreatedAt.IsSpecified == other.CreatedAt.IsSpecified) && (!this.CreatedAt.IsSpecified || (EqualityComparer<System.DateTimeOffset>.Default.Equals(this.CreatedAt.Value, other.CreatedAt.Value)));
    }
    

    bool IEquatable<Discord.Models.IThreadMetadataModel>.Equals(Discord.Models.IThreadMetadataModel? other) => Equals(other);
}
