namespace Discord.Models;

[ModelEquality]
public partial interface IEmbedModel : IModel
{
    Optional<string> Title { get; }
    Optional<string> Type { get; }
    Optional<string> Description { get; }
    Optional<string> Url { get; }
    Optional<DateTimeOffset> Timestamp { get; }
    Optional<uint> Color { get; }

    Optional<IEmbedFooterModel> Footer { get; }

    Optional<IEmbedImageModel> Image { get; }

    Optional<IEmbedThumbnailModel> Thumbnail { get; }

    Optional<IEmbedVideoModel> Video { get; }

    Optional<IEmbedProviderModel> Provider { get; }

    Optional<IEmbedAuthorModel> Author { get; }

    Optional<IReadOnlyCollection<IEmbedFieldModel>> Fields { get; }
}