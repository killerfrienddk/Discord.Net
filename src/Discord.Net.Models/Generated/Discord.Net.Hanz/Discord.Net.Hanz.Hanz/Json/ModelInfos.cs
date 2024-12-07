using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace Discord.Models;

public sealed partial class ModelJsonContext
{
    internal global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.ApplicationCommandPermissionUpdated> CreateApplicationCommandPermissionUpdatedTypeInfoNoConverter(global::System.Text.Json.JsonSerializerOptions options)
    {
        global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.ApplicationCommandPermissionUpdated> jsonTypeInfo;
        var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::Discord.Models.Json.ApplicationCommandPermissionUpdated>
        {
            ObjectCreator = () => new global::Discord.Models.Json.ApplicationCommandPermissionUpdated(),
            ObjectWithParameterizedConstructorCreator = null,
            PropertyMetadataInitializer = _ => ApplicationCommandPermissionUpdatedPropInit(options),
            ConstructorParameterMetadataInitializer = null,
            SerializeHandler = ApplicationCommandPermissionUpdatedSerializeHandler
        };
        jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::Discord.Models.Json.ApplicationCommandPermissionUpdated>(options, objectInfo);
        jsonTypeInfo.NumberHandling = null;
        jsonTypeInfo.OriginatingResolver = this;
        return jsonTypeInfo;
    }

    internal global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.AutoModerationRulePayload> CreateAutoModerationRulePayloadTypeInfoNoConverter(global::System.Text.Json.JsonSerializerOptions options)
    {
        global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.AutoModerationRulePayload> jsonTypeInfo;
        var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::Discord.Models.Json.AutoModerationRulePayload>
        {
            ObjectCreator = () => new global::Discord.Models.Json.AutoModerationRulePayload(),
            ObjectWithParameterizedConstructorCreator = null,
            PropertyMetadataInitializer = _ => AutoModerationRulePayloadPropInit(options),
            ConstructorParameterMetadataInitializer = null,
            SerializeHandler = AutoModerationRulePayloadSerializeHandler
        };
        jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::Discord.Models.Json.AutoModerationRulePayload>(options, objectInfo);
        jsonTypeInfo.NumberHandling = null;
        jsonTypeInfo.OriginatingResolver = this;
        return jsonTypeInfo;
    }

    internal global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.ChannelPayload> CreateChannelPayloadTypeInfoNoConverter(global::System.Text.Json.JsonSerializerOptions options)
    {
        global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.ChannelPayload> jsonTypeInfo;
        var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::Discord.Models.Json.ChannelPayload>
        {
            ObjectCreator = () => new global::Discord.Models.Json.ChannelPayload(),
            ObjectWithParameterizedConstructorCreator = null,
            PropertyMetadataInitializer = _ => ChannelPayloadPropInit(options),
            ConstructorParameterMetadataInitializer = null,
            SerializeHandler = ChannelPayloadSerializeHandler
        };
        jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::Discord.Models.Json.ChannelPayload>(options, objectInfo);
        jsonTypeInfo.NumberHandling = null;
        jsonTypeInfo.OriginatingResolver = this;
        return jsonTypeInfo;
    }

    internal global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.EntitlementPayload> CreateEntitlementPayloadTypeInfoNoConverter(global::System.Text.Json.JsonSerializerOptions options)
    {
        global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.EntitlementPayload> jsonTypeInfo;
        var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::Discord.Models.Json.EntitlementPayload>
        {
            ObjectCreator = () => new global::Discord.Models.Json.EntitlementPayload(),
            ObjectWithParameterizedConstructorCreator = null,
            PropertyMetadataInitializer = _ => EntitlementPayloadPropInit(options),
            ConstructorParameterMetadataInitializer = null,
            SerializeHandler = EntitlementPayloadSerializeHandler
        };
        jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::Discord.Models.Json.EntitlementPayload>(options, objectInfo);
        jsonTypeInfo.NumberHandling = null;
        jsonTypeInfo.OriginatingResolver = this;
        return jsonTypeInfo;
    }

    internal global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.GuildAuditLogEntryCreated> CreateGuildAuditLogEntryCreatedTypeInfoNoConverter(global::System.Text.Json.JsonSerializerOptions options)
    {
        global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.GuildAuditLogEntryCreated> jsonTypeInfo;
        var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::Discord.Models.Json.GuildAuditLogEntryCreated>
        {
            ObjectCreator = () => new global::Discord.Models.Json.GuildAuditLogEntryCreated(),
            ObjectWithParameterizedConstructorCreator = null,
            PropertyMetadataInitializer = _ => GuildAuditLogEntryCreatedPropInit(options),
            ConstructorParameterMetadataInitializer = null,
            SerializeHandler = GuildAuditLogEntryCreatedSerializeHandler
        };
        jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::Discord.Models.Json.GuildAuditLogEntryCreated>(options, objectInfo);
        jsonTypeInfo.NumberHandling = null;
        jsonTypeInfo.OriginatingResolver = this;
        return jsonTypeInfo;
    }

    internal global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.GuildCreated> CreateGuildCreatedTypeInfoNoConverter(global::System.Text.Json.JsonSerializerOptions options)
    {
        global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.GuildCreated> jsonTypeInfo;
        var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::Discord.Models.Json.GuildCreated>
        {
            ObjectCreator = null,
            ObjectWithParameterizedConstructorCreator = null,
            PropertyMetadataInitializer = _ => GuildCreatedPropInit(options),
            ConstructorParameterMetadataInitializer = null,
            SerializeHandler = GuildCreatedSerializeHandler
        };
        jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::Discord.Models.Json.GuildCreated>(options, objectInfo);
        jsonTypeInfo.NumberHandling = null;
        jsonTypeInfo.OriginatingResolver = this;
        return jsonTypeInfo;
    }

    internal global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.GuildMemberAdded> CreateGuildMemberAddedTypeInfoNoConverter(global::System.Text.Json.JsonSerializerOptions options)
    {
        global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.GuildMemberAdded> jsonTypeInfo;
        var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::Discord.Models.Json.GuildMemberAdded>
        {
            ObjectCreator = () => new global::Discord.Models.Json.GuildMemberAdded(),
            ObjectWithParameterizedConstructorCreator = null,
            PropertyMetadataInitializer = _ => GuildMemberAddedPropInit(options),
            ConstructorParameterMetadataInitializer = null,
            SerializeHandler = GuildMemberAddedSerializeHandler
        };
        jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::Discord.Models.Json.GuildMemberAdded>(options, objectInfo);
        jsonTypeInfo.NumberHandling = null;
        jsonTypeInfo.OriginatingResolver = this;
        return jsonTypeInfo;
    }

    internal global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.GuildScheduledEventPayload> CreateGuildScheduledEventPayloadTypeInfoNoConverter(global::System.Text.Json.JsonSerializerOptions options)
    {
        global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.GuildScheduledEventPayload> jsonTypeInfo;
        var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::Discord.Models.Json.GuildScheduledEventPayload>
        {
            ObjectCreator = () => new global::Discord.Models.Json.GuildScheduledEventPayload(),
            ObjectWithParameterizedConstructorCreator = null,
            PropertyMetadataInitializer = _ => GuildScheduledEventPayloadPropInit(options),
            ConstructorParameterMetadataInitializer = null,
            SerializeHandler = GuildScheduledEventPayloadSerializeHandler
        };
        jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::Discord.Models.Json.GuildScheduledEventPayload>(options, objectInfo);
        jsonTypeInfo.NumberHandling = null;
        jsonTypeInfo.OriginatingResolver = this;
        return jsonTypeInfo;
    }

    internal global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.GuildUpdated> CreateGuildUpdatedTypeInfoNoConverter(global::System.Text.Json.JsonSerializerOptions options)
    {
        global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.GuildUpdated> jsonTypeInfo;
        var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::Discord.Models.Json.GuildUpdated>
        {
            ObjectCreator = () => new global::Discord.Models.Json.GuildUpdated(),
            ObjectWithParameterizedConstructorCreator = null,
            PropertyMetadataInitializer = _ => GuildUpdatedPropInit(options),
            ConstructorParameterMetadataInitializer = null,
            SerializeHandler = GuildUpdatedSerializeHandler
        };
        jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::Discord.Models.Json.GuildUpdated>(options, objectInfo);
        jsonTypeInfo.NumberHandling = null;
        jsonTypeInfo.OriginatingResolver = this;
        return jsonTypeInfo;
    }

    internal global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.IntegrationCreatedUpdated> CreateIntegrationCreatedUpdatedTypeInfoNoConverter(global::System.Text.Json.JsonSerializerOptions options)
    {
        global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.IntegrationCreatedUpdated> jsonTypeInfo;
        var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::Discord.Models.Json.IntegrationCreatedUpdated>
        {
            ObjectCreator = () => new global::Discord.Models.Json.IntegrationCreatedUpdated(),
            ObjectWithParameterizedConstructorCreator = null,
            PropertyMetadataInitializer = _ => IntegrationCreatedUpdatedPropInit(options),
            ConstructorParameterMetadataInitializer = null,
            SerializeHandler = IntegrationCreatedUpdatedSerializeHandler
        };
        jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::Discord.Models.Json.IntegrationCreatedUpdated>(options, objectInfo);
        jsonTypeInfo.NumberHandling = null;
        jsonTypeInfo.OriginatingResolver = this;
        return jsonTypeInfo;
    }

    internal global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.InteractionCreated> CreateInteractionCreatedTypeInfoNoConverter(global::System.Text.Json.JsonSerializerOptions options)
    {
        global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.InteractionCreated> jsonTypeInfo;
        var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::Discord.Models.Json.InteractionCreated>
        {
            ObjectCreator = () => new global::Discord.Models.Json.InteractionCreated(),
            ObjectWithParameterizedConstructorCreator = null,
            PropertyMetadataInitializer = _ => InteractionCreatedPropInit(options),
            ConstructorParameterMetadataInitializer = null,
            SerializeHandler = InteractionCreatedSerializeHandler
        };
        jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::Discord.Models.Json.InteractionCreated>(options, objectInfo);
        jsonTypeInfo.NumberHandling = null;
        jsonTypeInfo.OriginatingResolver = this;
        return jsonTypeInfo;
    }

    internal global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.MessageCreatedUpdated> CreateMessageCreatedUpdatedTypeInfoNoConverter(global::System.Text.Json.JsonSerializerOptions options)
    {
        global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.MessageCreatedUpdated> jsonTypeInfo;
        var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::Discord.Models.Json.MessageCreatedUpdated>
        {
            ObjectCreator = null,
            ObjectWithParameterizedConstructorCreator = static args => new global::Discord.Models.Json.MessageCreatedUpdated()
            {
                Mentions = (global::Discord.Models.Json.MentionedUser[])args[0]
            },
            PropertyMetadataInitializer = _ => MessageCreatedUpdatedPropInit(options),
            ConstructorParameterMetadataInitializer = MessageCreatedUpdatedCtorParamInit,
            SerializeHandler = MessageCreatedUpdatedSerializeHandler
        };
        jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::Discord.Models.Json.MessageCreatedUpdated>(options, objectInfo);
        jsonTypeInfo.NumberHandling = null;
        jsonTypeInfo.OriginatingResolver = this;
        return jsonTypeInfo;
    }

    internal global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.PresenceUpdated> CreatePresenceUpdatedTypeInfoNoConverter(global::System.Text.Json.JsonSerializerOptions options)
    {
        global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.PresenceUpdated> jsonTypeInfo;
        var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::Discord.Models.Json.PresenceUpdated>
        {
            ObjectCreator = () => new global::Discord.Models.Json.PresenceUpdated(),
            ObjectWithParameterizedConstructorCreator = null,
            PropertyMetadataInitializer = _ => PresenceUpdatedPropInit(options),
            ConstructorParameterMetadataInitializer = null,
            SerializeHandler = PresenceUpdatedSerializeHandler
        };
        jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::Discord.Models.Json.PresenceUpdated>(options, objectInfo);
        jsonTypeInfo.NumberHandling = null;
        jsonTypeInfo.OriginatingResolver = this;
        return jsonTypeInfo;
    }

    internal global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.StageInstancePayload> CreateStageInstancePayloadTypeInfoNoConverter(global::System.Text.Json.JsonSerializerOptions options)
    {
        global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.StageInstancePayload> jsonTypeInfo;
        var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::Discord.Models.Json.StageInstancePayload>
        {
            ObjectCreator = () => new global::Discord.Models.Json.StageInstancePayload(),
            ObjectWithParameterizedConstructorCreator = null,
            PropertyMetadataInitializer = _ => StageInstancePayloadPropInit(options),
            ConstructorParameterMetadataInitializer = null,
            SerializeHandler = StageInstancePayloadSerializeHandler
        };
        jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::Discord.Models.Json.StageInstancePayload>(options, objectInfo);
        jsonTypeInfo.NumberHandling = null;
        jsonTypeInfo.OriginatingResolver = this;
        return jsonTypeInfo;
    }

    internal global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.ThreadCreated> CreateThreadCreatedTypeInfoNoConverter(global::System.Text.Json.JsonSerializerOptions options)
    {
        global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.ThreadCreated> jsonTypeInfo;
        var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::Discord.Models.Json.ThreadCreated>
        {
            ObjectCreator = () => new global::Discord.Models.Json.ThreadCreated(),
            ObjectWithParameterizedConstructorCreator = null,
            PropertyMetadataInitializer = _ => ThreadCreatedPropInit(options),
            ConstructorParameterMetadataInitializer = null,
            SerializeHandler = ThreadCreatedSerializeHandler
        };
        jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::Discord.Models.Json.ThreadCreated>(options, objectInfo);
        jsonTypeInfo.NumberHandling = null;
        jsonTypeInfo.OriginatingResolver = this;
        return jsonTypeInfo;
    }

    internal global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.ThreadMemberUpdated> CreateThreadMemberUpdatedTypeInfoNoConverter(global::System.Text.Json.JsonSerializerOptions options)
    {
        global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.ThreadMemberUpdated> jsonTypeInfo;
        var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::Discord.Models.Json.ThreadMemberUpdated>
        {
            ObjectCreator = () => new global::Discord.Models.Json.ThreadMemberUpdated(),
            ObjectWithParameterizedConstructorCreator = null,
            PropertyMetadataInitializer = _ => ThreadMemberUpdatedPropInit(options),
            ConstructorParameterMetadataInitializer = null,
            SerializeHandler = ThreadMemberUpdatedSerializeHandler
        };
        jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::Discord.Models.Json.ThreadMemberUpdated>(options, objectInfo);
        jsonTypeInfo.NumberHandling = null;
        jsonTypeInfo.OriginatingResolver = this;
        return jsonTypeInfo;
    }

    internal global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.UserUpdated> CreateUserUpdatedTypeInfoNoConverter(global::System.Text.Json.JsonSerializerOptions options)
    {
        global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.UserUpdated> jsonTypeInfo;
        var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::Discord.Models.Json.UserUpdated>
        {
            ObjectCreator = () => new global::Discord.Models.Json.UserUpdated(),
            ObjectWithParameterizedConstructorCreator = null,
            PropertyMetadataInitializer = _ => UserUpdatedPropInit(options),
            ConstructorParameterMetadataInitializer = null,
            SerializeHandler = UserUpdatedSerializeHandler
        };
        jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::Discord.Models.Json.UserUpdated>(options, objectInfo);
        jsonTypeInfo.NumberHandling = null;
        jsonTypeInfo.OriginatingResolver = this;
        return jsonTypeInfo;
    }

    internal global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.VoiceStateUpdated> CreateVoiceStateUpdatedTypeInfoNoConverter(global::System.Text.Json.JsonSerializerOptions options)
    {
        global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.VoiceStateUpdated> jsonTypeInfo;
        var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::Discord.Models.Json.VoiceStateUpdated>
        {
            ObjectCreator = () => new global::Discord.Models.Json.VoiceStateUpdated(),
            ObjectWithParameterizedConstructorCreator = null,
            PropertyMetadataInitializer = _ => VoiceStateUpdatedPropInit(options),
            ConstructorParameterMetadataInitializer = null,
            SerializeHandler = VoiceStateUpdatedSerializeHandler
        };
        jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::Discord.Models.Json.VoiceStateUpdated>(options, objectInfo);
        jsonTypeInfo.NumberHandling = null;
        jsonTypeInfo.OriginatingResolver = this;
        return jsonTypeInfo;
    }

    internal global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.ExtendedGuild> CreateExtendedGuildTypeInfoNoConverter(global::System.Text.Json.JsonSerializerOptions options)
    {
        global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.ExtendedGuild> jsonTypeInfo;
        var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::Discord.Models.Json.ExtendedGuild>
        {
            ObjectCreator = null,
            ObjectWithParameterizedConstructorCreator = static args => new global::Discord.Models.Json.ExtendedGuild()
            {
                VoiceStates = (global::Discord.Models.Json.PartialVoiceState[])args[0],
                Members = (global::Discord.Models.Json.GuildMember[])args[1],
                Channels = (global::Discord.Models.Json.GuildChannelBase[])args[2],
                Threads = (global::Discord.Models.Json.ThreadChannelBase[])args[3],
                Presences = (global::Discord.Models.Json.Presence[])args[4],
                StageInstances = (global::Discord.Models.Json.StageInstance[])args[5],
                GuildScheduledEvents = (global::Discord.Models.Json.GuildScheduledEvent[])args[6]
            },
            PropertyMetadataInitializer = _ => ExtendedGuildPropInit(options),
            ConstructorParameterMetadataInitializer = ExtendedGuildCtorParamInit,
            SerializeHandler = ExtendedGuildSerializeHandler
        };
        jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::Discord.Models.Json.ExtendedGuild>(options, objectInfo);
        jsonTypeInfo.NumberHandling = null;
        jsonTypeInfo.OriginatingResolver = this;
        return jsonTypeInfo;
    }

    internal global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.MentionedUser> CreateMentionedUserTypeInfoNoConverter(global::System.Text.Json.JsonSerializerOptions options)
    {
        global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.MentionedUser> jsonTypeInfo;
        var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::Discord.Models.Json.MentionedUser>
        {
            ObjectCreator = null,
            ObjectWithParameterizedConstructorCreator = static args => new global::Discord.Models.Json.MentionedUser()
            {
                Member = (global::Discord.Models.Json.PartialGuildMember)args[0]
            },
            PropertyMetadataInitializer = _ => MentionedUserPropInit(options),
            ConstructorParameterMetadataInitializer = MentionedUserCtorParamInit,
            SerializeHandler = MentionedUserSerializeHandler
        };
        jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::Discord.Models.Json.MentionedUser>(options, objectInfo);
        jsonTypeInfo.NumberHandling = null;
        jsonTypeInfo.OriginatingResolver = this;
        return jsonTypeInfo;
    }

    internal global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.HeartbeatPayloadData> CreateHeartbeatPayloadDataTypeInfoNoConverter(global::System.Text.Json.JsonSerializerOptions options)
    {
        global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.HeartbeatPayloadData> jsonTypeInfo;
        var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::Discord.Models.Json.HeartbeatPayloadData>
        {
            ObjectCreator = () => new global::Discord.Models.Json.HeartbeatPayloadData(),
            ObjectWithParameterizedConstructorCreator = null,
            PropertyMetadataInitializer = _ => HeartbeatPayloadDataPropInit(options),
            ConstructorParameterMetadataInitializer = null,
            SerializeHandler = HeartbeatPayloadDataSerializeHandler
        };
        jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::Discord.Models.Json.HeartbeatPayloadData>(options, objectInfo);
        jsonTypeInfo.NumberHandling = null;
        jsonTypeInfo.OriginatingResolver = this;
        return jsonTypeInfo;
    }

    internal global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.InvalidSessionPayloadData> CreateInvalidSessionPayloadDataTypeInfoNoConverter(global::System.Text.Json.JsonSerializerOptions options)
    {
        global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.InvalidSessionPayloadData> jsonTypeInfo;
        var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::Discord.Models.Json.InvalidSessionPayloadData>
        {
            ObjectCreator = () => new global::Discord.Models.Json.InvalidSessionPayloadData(),
            ObjectWithParameterizedConstructorCreator = null,
            PropertyMetadataInitializer = _ => InvalidSessionPayloadDataPropInit(options),
            ConstructorParameterMetadataInitializer = null,
            SerializeHandler = InvalidSessionPayloadDataSerializeHandler
        };
        jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::Discord.Models.Json.InvalidSessionPayloadData>(options, objectInfo);
        jsonTypeInfo.NumberHandling = null;
        jsonTypeInfo.OriginatingResolver = this;
        return jsonTypeInfo;
    }

    internal global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.ApplicationCommand> CreateApplicationCommandTypeInfoNoConverter(global::System.Text.Json.JsonSerializerOptions options)
    {
        global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.ApplicationCommand> jsonTypeInfo;
        var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::Discord.Models.Json.ApplicationCommand>
        {
            ObjectCreator = null,
            ObjectWithParameterizedConstructorCreator = static args => new global::Discord.Models.Json.ApplicationCommand()
            {
                Name = (string)args[0],
                Description = (string)args[1]
            },
            PropertyMetadataInitializer = _ => ApplicationCommandPropInit(options),
            ConstructorParameterMetadataInitializer = ApplicationCommandCtorParamInit,
            SerializeHandler = ApplicationCommandSerializeHandler
        };
        jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::Discord.Models.Json.ApplicationCommand>(options, objectInfo);
        jsonTypeInfo.NumberHandling = null;
        jsonTypeInfo.OriginatingResolver = this;
        return jsonTypeInfo;
    }

    internal global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.ApplicationCommandOption> CreateApplicationCommandOptionTypeInfoNoConverter(global::System.Text.Json.JsonSerializerOptions options)
    {
        global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.ApplicationCommandOption> jsonTypeInfo;
        var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::Discord.Models.Json.ApplicationCommandOption>
        {
            ObjectCreator = null,
            ObjectWithParameterizedConstructorCreator = static args => new global::Discord.Models.Json.ApplicationCommandOption()
            {
                Name = (string)args[0],
                Description = (string)args[1]
            },
            PropertyMetadataInitializer = _ => ApplicationCommandOptionPropInit(options),
            ConstructorParameterMetadataInitializer = ApplicationCommandOptionCtorParamInit,
            SerializeHandler = ApplicationCommandOptionSerializeHandler
        };
        jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::Discord.Models.Json.ApplicationCommandOption>(options, objectInfo);
        jsonTypeInfo.NumberHandling = null;
        jsonTypeInfo.OriginatingResolver = this;
        return jsonTypeInfo;
    }

    internal global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.AutoModerationAction> CreateAutoModerationActionTypeInfoNoConverter(global::System.Text.Json.JsonSerializerOptions options)
    {
        global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.AutoModerationAction> jsonTypeInfo;
        var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::Discord.Models.Json.AutoModerationAction>
        {
            ObjectCreator = () => new global::Discord.Models.Json.AutoModerationAction(),
            ObjectWithParameterizedConstructorCreator = null,
            PropertyMetadataInitializer = _ => AutoModerationActionPropInit(options),
            ConstructorParameterMetadataInitializer = null,
            SerializeHandler = AutoModerationActionSerializeHandler
        };
        jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::Discord.Models.Json.AutoModerationAction>(options, objectInfo);
        jsonTypeInfo.NumberHandling = null;
        jsonTypeInfo.OriginatingResolver = this;
        return jsonTypeInfo;
    }

    internal global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.AutoModerationRule> CreateAutoModerationRuleTypeInfoNoConverter(global::System.Text.Json.JsonSerializerOptions options)
    {
        global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.AutoModerationRule> jsonTypeInfo;
        var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::Discord.Models.Json.AutoModerationRule>
        {
            ObjectCreator = null,
            ObjectWithParameterizedConstructorCreator = static args => new global::Discord.Models.Json.AutoModerationRule()
            {
                Name = (string)args[0],
                Actions = (global::Discord.Models.Json.AutoModerationAction[])args[1],
                ExemptRoles = (ulong[])args[2],
                ExemptChannels = (ulong[])args[3]
            },
            PropertyMetadataInitializer = _ => AutoModerationRulePropInit(options),
            ConstructorParameterMetadataInitializer = AutoModerationRuleCtorParamInit,
            SerializeHandler = AutoModerationRuleSerializeHandler
        };
        jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::Discord.Models.Json.AutoModerationRule>(options, objectInfo);
        jsonTypeInfo.NumberHandling = null;
        jsonTypeInfo.OriginatingResolver = this;
        return jsonTypeInfo;
    }

    internal global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.Channel> CreateChannelTypeInfoNoConverter(global::System.Text.Json.JsonSerializerOptions options)
    {
        global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.Channel> jsonTypeInfo;
        var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::Discord.Models.Json.Channel>
        {
            ObjectCreator = () => new global::Discord.Models.Json.Channel(),
            ObjectWithParameterizedConstructorCreator = null,
            PropertyMetadataInitializer = _ => ChannelPropInit(options),
            ConstructorParameterMetadataInitializer = null,
            SerializeHandler = ChannelSerializeHandler
        };
        jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::Discord.Models.Json.Channel>(options, objectInfo);
        jsonTypeInfo.NumberHandling = null;
        jsonTypeInfo.OriginatingResolver = this;
        return jsonTypeInfo;
    }

    internal global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.ThreadChannelBase> CreateThreadChannelBaseTypeInfoNoConverter(global::System.Text.Json.JsonSerializerOptions options)
    {
        global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.ThreadChannelBase> jsonTypeInfo;
        var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::Discord.Models.Json.ThreadChannelBase>
        {
            ObjectCreator = null,
            ObjectWithParameterizedConstructorCreator = null,
            PropertyMetadataInitializer = _ => ThreadChannelBasePropInit(options),
            ConstructorParameterMetadataInitializer = null,
            SerializeHandler = ThreadChannelBaseSerializeHandler
        };
        jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::Discord.Models.Json.ThreadChannelBase>(options, objectInfo);
        jsonTypeInfo.NumberHandling = null;
        jsonTypeInfo.OriginatingResolver = this;
        return jsonTypeInfo;
    }

    internal global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.GuildChannelBase> CreateGuildChannelBaseTypeInfoNoConverter(global::System.Text.Json.JsonSerializerOptions options)
    {
        global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.GuildChannelBase> jsonTypeInfo;
        var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::Discord.Models.Json.GuildChannelBase>
        {
            ObjectCreator = null,
            ObjectWithParameterizedConstructorCreator = null,
            PropertyMetadataInitializer = _ => GuildChannelBasePropInit(options),
            ConstructorParameterMetadataInitializer = null,
            SerializeHandler = GuildChannelBaseSerializeHandler
        };
        jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::Discord.Models.Json.GuildChannelBase>(options, objectInfo);
        jsonTypeInfo.NumberHandling = null;
        jsonTypeInfo.OriginatingResolver = this;
        return jsonTypeInfo;
    }

    internal global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.ThreadableChannelBase> CreateThreadableChannelBaseTypeInfoNoConverter(global::System.Text.Json.JsonSerializerOptions options)
    {
        global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.ThreadableChannelBase> jsonTypeInfo;
        var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::Discord.Models.Json.ThreadableChannelBase>
        {
            ObjectCreator = null,
            ObjectWithParameterizedConstructorCreator = static args => new global::Discord.Models.Json.ThreadableChannelBase()
            {
                Name = (string)args[0]
            },
            PropertyMetadataInitializer = _ => ThreadableChannelBasePropInit(options),
            ConstructorParameterMetadataInitializer = ThreadableChannelBaseCtorParamInit,
            SerializeHandler = ThreadableChannelBaseSerializeHandler
        };
        jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::Discord.Models.Json.ThreadableChannelBase>(options, objectInfo);
        jsonTypeInfo.NumberHandling = null;
        jsonTypeInfo.OriginatingResolver = this;
        return jsonTypeInfo;
    }

    internal global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.Emote> CreateEmoteTypeInfoNoConverter(global::System.Text.Json.JsonSerializerOptions options)
    {
        global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.Emote> jsonTypeInfo;
        var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::Discord.Models.Json.Emote>
        {
            ObjectCreator = null,
            ObjectWithParameterizedConstructorCreator = null,
            PropertyMetadataInitializer = _ => EmotePropInit(options),
            ConstructorParameterMetadataInitializer = null,
            SerializeHandler = EmoteSerializeHandler
        };
        jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::Discord.Models.Json.Emote>(options, objectInfo);
        jsonTypeInfo.NumberHandling = null;
        jsonTypeInfo.OriginatingResolver = this;
        return jsonTypeInfo;
    }

    internal global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.Interaction> CreateInteractionTypeInfoNoConverter(global::System.Text.Json.JsonSerializerOptions options)
    {
        global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.Interaction> jsonTypeInfo;
        var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::Discord.Models.Json.Interaction>
        {
            ObjectCreator = null,
            ObjectWithParameterizedConstructorCreator = static args => new global::Discord.Models.Json.Interaction()
            {
                Token = (string)args[0],
                Entitlements = (global::Discord.Models.Json.Entitlement[])args[1],
                AuthorizingIntegrationOwners = (global::Discord.Models.Json.ApplicationIntegrationTypes)args[2]
            },
            PropertyMetadataInitializer = _ => InteractionPropInit(options),
            ConstructorParameterMetadataInitializer = InteractionCtorParamInit,
            SerializeHandler = InteractionSerializeHandler
        };
        jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::Discord.Models.Json.Interaction>(options, objectInfo);
        jsonTypeInfo.NumberHandling = null;
        jsonTypeInfo.OriginatingResolver = this;
        return jsonTypeInfo;
    }

    internal global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.SoundboardSound> CreateSoundboardSoundTypeInfoNoConverter(global::System.Text.Json.JsonSerializerOptions options)
    {
        global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.SoundboardSound> jsonTypeInfo;
        var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::Discord.Models.Json.SoundboardSound>
        {
            ObjectCreator = null,
            ObjectWithParameterizedConstructorCreator = static args => new global::Discord.Models.Json.SoundboardSound()
            {
                Name = (string)args[0]
            },
            PropertyMetadataInitializer = _ => SoundboardSoundPropInit(options),
            ConstructorParameterMetadataInitializer = SoundboardSoundCtorParamInit,
            SerializeHandler = SoundboardSoundSerializeHandler
        };
        jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::Discord.Models.Json.SoundboardSound>(options, objectInfo);
        jsonTypeInfo.NumberHandling = null;
        jsonTypeInfo.OriginatingResolver = this;
        return jsonTypeInfo;
    }

    internal global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.Webhook> CreateWebhookTypeInfoNoConverter(global::System.Text.Json.JsonSerializerOptions options)
    {
        global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.Webhook> jsonTypeInfo;
        var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::Discord.Models.Json.Webhook>
        {
            ObjectCreator = () => new global::Discord.Models.Json.Webhook(),
            ObjectWithParameterizedConstructorCreator = null,
            PropertyMetadataInitializer = _ => WebhookPropInit(options),
            ConstructorParameterMetadataInitializer = null,
            SerializeHandler = WebhookSerializeHandler
        };
        jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::Discord.Models.Json.Webhook>(options, objectInfo);
        jsonTypeInfo.NumberHandling = null;
        jsonTypeInfo.OriginatingResolver = this;
        return jsonTypeInfo;
    }
}