namespace Discord.Models;

[ModelEquality]
public partial interface IMessageSnapshotModel : IModel
{
    IMessageSnapshotMessageModel Message { get; }   
}