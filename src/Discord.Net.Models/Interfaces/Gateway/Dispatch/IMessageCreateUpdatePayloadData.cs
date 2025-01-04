namespace Discord.Models;

public interface IMessageCreateUpdatePayloadData : IGatewayPayloadData, IMessageModel
{
    Optional<ulong> GuildId { get; }
    Optional<IPartialMemberModel> Member { get; }
    
    new IReadOnlyCollection<IMessageCreateMentionedUserModel> Mentions { get; }

    IReadOnlyCollection<ModelOrId<IUserModel, ulong>> IMessageModel.Mentions
        => Mentions
            .Select(x => new ModelOrId<IUserModel, ulong>(x))
            .ToList()
            .AsReadOnly();
}

[ModelEquality]
public partial interface IMessageCreateMentionedUserModel : IUserModel
{
    IPartialMemberModel Member { get; }
}
