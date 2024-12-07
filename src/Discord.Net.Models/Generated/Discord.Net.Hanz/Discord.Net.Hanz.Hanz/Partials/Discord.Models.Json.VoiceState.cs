using System.Text.Json.Serialization;

namespace Discord.Models.Json;

public sealed class PartialVoiceState : IPartial<Discord.Models.Json.VoiceState>, Discord.Models.IPartialVoiceStateModel, Discord.Models.IEntityModel<ulong>, Discord.Models.IModel, Discord.Models.IModelSourceOf<Discord.Models.IMemberModel?>
{
    [JsonPropertyName("guild_id")]
    public Discord.Optional<ulong> GuildId { get; set; }

    [JsonPropertyName("channel_id")]
    public Discord.Optional<ulong?> ChannelId { get; set; }

    [JsonPropertyName("user_id"), PartialIgnore]
    public ulong UserId { get; set; }

    // ALWAYS sent over WebSocket, never on REST
    [JsonPropertyName("member")]
    public Discord.Optional<Discord.Models.Json.GuildMember> Member { get; set; }

    [JsonPropertyName("session_id")]
    public Discord.Optional<string> SessionId { get; set; }

    [JsonPropertyName("deaf")]
    public Discord.Optional<bool> Deaf { get; set; }

    [JsonPropertyName("mute")]
    public Discord.Optional<bool> Mute { get; set; }

    [JsonPropertyName("self_deaf")]
    public Discord.Optional<bool> SelfDeaf { get; set; }

    [JsonPropertyName("self_mute")]
    public Discord.Optional<bool> SelfMute { get; set; }

    [JsonPropertyName("self_stream")]
    public Discord.Optional<bool?> SelfStream { get; set; }

    [JsonPropertyName("self_video")]
    public Discord.Optional<bool> SelfVideo { get; set; }

    [JsonPropertyName("suppress")]
    public Discord.Optional<bool> Suppress { get; set; }

    [JsonPropertyName("request_to_speak_timestamp")]
    public Discord.Optional<System.DateTimeOffset?> RequestToSpeakTimestamp { get; set; }

    public bool ApplyTo(Discord.Models.Json.VoiceState model)
    {
        var result = false;
        if (GuildId.IsSpecified)
        {
            result |= true;
            model.GuildId = GuildId.Value;
        }

        if (ChannelId.IsSpecified)
        {
            result |= true;
            model.ChannelId = ChannelId.Value;
        }

        if (Member.IsSpecified)
        {
            result |= true;
            model.Member = Member.Value;
        }

        if (SessionId.IsSpecified)
        {
            result |= true;
            model.SessionId = SessionId.Value;
        }

        if (Deaf.IsSpecified)
        {
            result |= true;
            model.Deaf = Deaf.Value;
        }

        if (Mute.IsSpecified)
        {
            result |= true;
            model.Mute = Mute.Value;
        }

        if (SelfDeaf.IsSpecified)
        {
            result |= true;
            model.SelfDeaf = SelfDeaf.Value;
        }

        if (SelfMute.IsSpecified)
        {
            result |= true;
            model.SelfMute = SelfMute.Value;
        }

        if (SelfStream.IsSpecified)
        {
            result |= true;
            model.SelfStream = SelfStream.Value;
        }

        if (SelfVideo.IsSpecified)
        {
            result |= true;
            model.SelfVideo = SelfVideo.Value;
        }

        if (Suppress.IsSpecified)
        {
            result |= true;
            model.Suppress = Suppress.Value;
        }

        if (RequestToSpeakTimestamp.IsSpecified)
        {
            result |= true;
            model.RequestToSpeakTimestamp = RequestToSpeakTimestamp.Value;
        }

        return result;
    }

    public Type UnderlyingModelType => typeof(Discord.Models.Json.VoiceState);

    public bool Has(string property)
    {
        return property switch
        {
            "GuildId" => GuildId.IsSpecified,
            "ChannelId" => ChannelId.IsSpecified,
            "UserId" => true,
            "Member" => Member.IsSpecified,
            "SessionId" => SessionId.IsSpecified,
            "Deaf" => Deaf.IsSpecified,
            "Mute" => Mute.IsSpecified,
            "SelfDeaf" => SelfDeaf.IsSpecified,
            "SelfMute" => SelfMute.IsSpecified,
            "SelfStream" => SelfStream.IsSpecified,
            "SelfVideo" => SelfVideo.IsSpecified,
            "Suppress" => Suppress.IsSpecified,
            "RequestToSpeakTimestamp" => RequestToSpeakTimestamp.IsSpecified,
            _ => false
        };
    }

    public bool TryGet<T>(string property, out T result)
    {
        return property switch
        {
            "GuildId" when GuildId is { IsSpecified: true, Value: T val } => (result = val) is T,
            "ChannelId" when ChannelId is { IsSpecified: true, Value: T val } => (result = val) is T,
            "UserId" when UserId is T val => (result = val) is T,
            "Member" when Member is { IsSpecified: true, Value: T val } => (result = val) is T,
            "SessionId" when SessionId is { IsSpecified: true, Value: T val } => (result = val) is T,
            "Deaf" when Deaf is { IsSpecified: true, Value: T val } => (result = val) is T,
            "Mute" when Mute is { IsSpecified: true, Value: T val } => (result = val) is T,
            "SelfDeaf" when SelfDeaf is { IsSpecified: true, Value: T val } => (result = val) is T,
            "SelfMute" when SelfMute is { IsSpecified: true, Value: T val } => (result = val) is T,
            "SelfStream" when SelfStream is { IsSpecified: true, Value: T val } => (result = val) is T,
            "SelfVideo" when SelfVideo is { IsSpecified: true, Value: T val } => (result = val) is T,
            "Suppress" when Suppress is { IsSpecified: true, Value: T val } => (result = val) is T,
            "RequestToSpeakTimestamp" when RequestToSpeakTimestamp is { IsSpecified: true, Value: T val } => (result = val) is T,
            _ => (result = default(T)!)is not T
        };
    }

    string? Discord.Models.IPartialVoiceStateModel.SessionId => ~SessionId;

    bool Discord.Models.IPartialVoiceStateModel.SessionIdIsSpecified => SessionId.IsSpecified;

    ulong? Discord.Models.IPartialVoiceStateModel.ChannelId => ~ChannelId;

    bool Discord.Models.IPartialVoiceStateModel.ChannelIdIsSpecified => ChannelId.IsSpecified;

    ulong? Discord.Models.IPartialVoiceStateModel.GuildId => ~GuildId;

    bool Discord.Models.IPartialVoiceStateModel.GuildIdIsSpecified => GuildId.IsSpecified;

    bool? Discord.Models.IPartialVoiceStateModel.Deaf => Deaf.ToNullable();

    bool Discord.Models.IPartialVoiceStateModel.DeafIsSpecified => Deaf.IsSpecified;

    bool? Discord.Models.IPartialVoiceStateModel.Mute => Mute.ToNullable();

    bool Discord.Models.IPartialVoiceStateModel.MuteIsSpecified => Mute.IsSpecified;

    bool? Discord.Models.IPartialVoiceStateModel.SelfDeaf => SelfDeaf.ToNullable();

    bool Discord.Models.IPartialVoiceStateModel.SelfDeafIsSpecified => SelfDeaf.IsSpecified;

    bool? Discord.Models.IPartialVoiceStateModel.SelfMute => SelfMute.ToNullable();

    bool Discord.Models.IPartialVoiceStateModel.SelfMuteIsSpecified => SelfMute.IsSpecified;

    bool? Discord.Models.IPartialVoiceStateModel.SelfStream => ~SelfStream;

    bool Discord.Models.IPartialVoiceStateModel.SelfStreamIsSpecified => SelfStream.IsSpecified;

    bool? Discord.Models.IPartialVoiceStateModel.SelfVideo => SelfVideo.ToNullable();

    bool Discord.Models.IPartialVoiceStateModel.SelfVideoIsSpecified => SelfVideo.IsSpecified;

    bool? Discord.Models.IPartialVoiceStateModel.Suppress => Suppress.ToNullable();

    bool Discord.Models.IPartialVoiceStateModel.SuppressIsSpecified => Suppress.IsSpecified;

    System.DateTimeOffset? Discord.Models.IPartialVoiceStateModel.RequestToSpeakTimestamp => ~RequestToSpeakTimestamp;

    bool Discord.Models.IPartialVoiceStateModel.RequestToSpeakTimestampIsSpecified => RequestToSpeakTimestamp.IsSpecified;

    bool Discord.Models.IPartial<Discord.Models.IVoiceStateModel>.ApplyTo(Discord.Models.IVoiceStateModel model) => model is Discord.Models.Json.VoiceState ourModel && ApplyTo(ourModel);
    public IEnumerable<IModel> GetDefinedModels()
    {
        if (Member.IsSpecified)
            yield return Member.Value;
    }

    Discord.Models.IMemberModel? Discord.Models.IModelSourceOf<Discord.Models.IMemberModel?>.Model => ~Member;
}