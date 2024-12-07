using System.Text.Json.Serialization;

namespace Discord.Models.Json;

public sealed partial class MentionedUser : IExtendedModel<Discord.Models.Json.User>
{
    Discord.Models.Json.User IExtendedModel<Discord.Models.Json.User>.ExtendedValue => User;

    string Discord.Models.IUserModel.Username => (User as Discord.Models.IUserModel).Username;

    string Discord.Models.IUserModel.Discriminator => (User as Discord.Models.IUserModel).Discriminator;

    string? Discord.Models.IUserModel.GlobalName => (User as Discord.Models.IUserModel).GlobalName;

    string? Discord.Models.IUserModel.Avatar => (User as Discord.Models.IUserModel).Avatar;

    bool? Discord.Models.IUserModel.IsBot => (User as Discord.Models.IUserModel).IsBot;

    bool? Discord.Models.IUserModel.IsSystem => (User as Discord.Models.IUserModel).IsSystem;

    int? Discord.Models.IUserModel.Flags => (User as Discord.Models.IUserModel).Flags;

    int? Discord.Models.IUserModel.PublicFlags => (User as Discord.Models.IUserModel).PublicFlags;

    Discord.Models.IAvatarDecorationDataModel? Discord.Models.IUserModel.AvatarDecoration => (User as Discord.Models.IUserModel).AvatarDecoration;

    ulong Discord.Models.IEntityModel<ulong>.Id => (User as Discord.Models.IEntityModel<ulong>).Id;
}