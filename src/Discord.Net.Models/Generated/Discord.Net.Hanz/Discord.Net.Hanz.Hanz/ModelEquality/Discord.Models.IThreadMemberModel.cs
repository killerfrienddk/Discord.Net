using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IThreadMemberModel : 
    IEquatable<Discord.Models.IThreadMemberModel>
{
    new bool Equals(Discord.Models.IThreadMemberModel? other)
    {
        if(other is null) return false;
        
        return
            (this.ThreadId.IsSpecified == other.ThreadId.IsSpecified) && (!this.ThreadId.IsSpecified || (EqualityComparer<ulong>.Default.Equals(this.ThreadId.Value, other.ThreadId.Value))) &&
            (this.UserId.IsSpecified == other.UserId.IsSpecified) && (!this.UserId.IsSpecified || (EqualityComparer<ulong>.Default.Equals(this.UserId.Value, other.UserId.Value))) &&
            EqualityComparer<System.DateTimeOffset>.Default.Equals(this.JoinTimestamp, other.JoinTimestamp) &&
            EqualityComparer<int>.Default.Equals(this.Flags, other.Flags) &&
            (this.Member.IsSpecified == other.Member.IsSpecified) && (!this.Member.IsSpecified || (EqualityComparer<Discord.Models.ModelOrId<Discord.Models.IMemberModel, ulong>>.Default.Equals(this.Member.Value, other.Member.Value)));
    }
    

    bool IEquatable<Discord.Models.IThreadMemberModel>.Equals(Discord.Models.IThreadMemberModel? other) => Equals(other);
}
