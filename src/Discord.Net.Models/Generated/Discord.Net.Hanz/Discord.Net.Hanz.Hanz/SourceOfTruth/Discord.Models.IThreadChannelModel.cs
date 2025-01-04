namespace Discord.Models;

public partial interface IThreadChannelModel
{
    Discord.Optional<ulong?> IGuildChannelModel.ParentId => ParentId;
}
