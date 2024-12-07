

namespace Discord.Models;

public partial interface IAttachmentModel : IEquatable<IAttachmentModel>
{
    new bool Equals(Discord.Models.IAttachmentModel? other)
    {
        if (other is null)
            return false;
        return this.Filename.Equals(this.Filename) && (this.Description?.Equals(this.Description) ?? this.Description is not null) && (this.ContentType?.Equals(this.ContentType) ?? this.ContentType is not null) && this.Size.Equals(this.Size) && this.Url.Equals(this.Url) && this.ProxyUrl.Equals(this.ProxyUrl) && (this.Height?.Equals(this.Height) ?? this.Height is not null) && (this.Width?.Equals(this.Width) ?? this.Width is not null) && this.Ephemeral.Equals(this.Ephemeral) && (this.Duration?.Equals(this.Duration) ?? this.Duration is not null) && (this.Waveform?.Equals(this.Waveform) ?? this.Waveform is not null) && (this.Flags?.Equals(this.Flags) ?? this.Flags is not null);
    }

    bool IEquatable<IAttachmentModel>.Equals(IAttachmentModel? other) => Equals(other);
    bool IEquatable<IModel>.Equals(IModel? other) => other is IAttachmentModel otherThis && Equals(otherThis);
}