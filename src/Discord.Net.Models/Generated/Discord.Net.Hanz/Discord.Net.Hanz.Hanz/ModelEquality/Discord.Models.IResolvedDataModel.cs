using System.Linq;
using Discord.Models.Json;
using Discord.Models;
using Discord;

namespace Discord.Models;

public partial interface IResolvedDataModel : 
    IEquatable<Discord.Models.IResolvedDataModel>
{
    new bool Equals(Discord.Models.IResolvedDataModel? other)
    {
        if(other is null) return false;
        
        return
            (this.Users.IsSpecified == other.Users.IsSpecified) && (!this.Users.IsSpecified || ((this.Users.Value is null == other.Users.Value is null) && (this.Users.Value is null || (this.Users.Value.Count == other.Users.Value.Count && this.Users.Value.All(kvp => other.Users.Value.ContainsKey(kvp.Key) && EqualityComparer<Discord.Models.IUserModel>.Default.Equals(kvp.Value, other.Users.Value[kvp.Key])))))) &&
            (this.Members.IsSpecified == other.Members.IsSpecified) && (!this.Members.IsSpecified || ((this.Members.Value is null == other.Members.Value is null) && (this.Members.Value is null || (this.Members.Value.Count == other.Members.Value.Count && this.Members.Value.All(kvp => other.Members.Value.ContainsKey(kvp.Key) && EqualityComparer<IPartialMemberModel>.Default.Equals(kvp.Value, other.Members.Value[kvp.Key])))))) &&
            (this.Roles.IsSpecified == other.Roles.IsSpecified) && (!this.Roles.IsSpecified || ((this.Roles.Value is null == other.Roles.Value is null) && (this.Roles.Value is null || (this.Roles.Value.Count == other.Roles.Value.Count && this.Roles.Value.All(kvp => other.Roles.Value.ContainsKey(kvp.Key) && EqualityComparer<Discord.Models.IRoleModel>.Default.Equals(kvp.Value, other.Roles.Value[kvp.Key])))))) &&
            (this.Channels.IsSpecified == other.Channels.IsSpecified) && (!this.Channels.IsSpecified || ((this.Channels.Value is null == other.Channels.Value is null) && (this.Channels.Value is null || (this.Channels.Value.Count == other.Channels.Value.Count && this.Channels.Value.All(kvp => other.Channels.Value.ContainsKey(kvp.Key) && EqualityComparer<IPartialChannelModel>.Default.Equals(kvp.Value, other.Channels.Value[kvp.Key])))))) &&
            (this.Messages.IsSpecified == other.Messages.IsSpecified) && (!this.Messages.IsSpecified || ((this.Messages.Value is null == other.Messages.Value is null) && (this.Messages.Value is null || (this.Messages.Value.Count == other.Messages.Value.Count && this.Messages.Value.All(kvp => other.Messages.Value.ContainsKey(kvp.Key) && EqualityComparer<IPartialMessageModel>.Default.Equals(kvp.Value, other.Messages.Value[kvp.Key])))))) &&
            (this.Attachments.IsSpecified == other.Attachments.IsSpecified) && (!this.Attachments.IsSpecified || ((this.Attachments.Value is null == other.Attachments.Value is null) && (this.Attachments.Value is null || (this.Attachments.Value.Count == other.Attachments.Value.Count && this.Attachments.Value.All(kvp => other.Attachments.Value.ContainsKey(kvp.Key) && EqualityComparer<Discord.Models.IAttachmentModel>.Default.Equals(kvp.Value, other.Attachments.Value[kvp.Key]))))));
    }
    

    bool IEquatable<Discord.Models.IResolvedDataModel>.Equals(Discord.Models.IResolvedDataModel? other) => Equals(other);
}
