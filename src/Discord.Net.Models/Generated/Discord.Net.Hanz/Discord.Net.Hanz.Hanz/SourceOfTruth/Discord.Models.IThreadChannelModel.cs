namespace Discord.Models;

public partial interface IThreadChannelModel
{
    ulong? IGuildChannelModel.ParentId => ParentId;
}
