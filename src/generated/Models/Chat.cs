// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Chat : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The chatType property</summary>
        public global::ApiSdk.Models.ChatType? ChatType { get; set; }
        /// <summary>Date and time at which the chat was created. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>A collection of all the apps in the chat. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.TeamsAppInstallation>? InstalledApps { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.TeamsAppInstallation> InstalledApps { get; set; }
#endif
        /// <summary>Preview of the last message sent in the chat. Null if no messages were sent in the chat. Currently, only the list chats operation supports this property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.ChatMessageInfo? LastMessagePreview { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.ChatMessageInfo LastMessagePreview { get; set; }
#endif
        /// <summary>Date and time at which the chat was renamed or the list of members was last changed. Read-only.</summary>
        public DateTimeOffset? LastUpdatedDateTime { get; set; }
        /// <summary>A collection of all the members in the chat. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ConversationMember>? Members { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ConversationMember> Members { get; set; }
#endif
        /// <summary>A collection of all the messages in the chat. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ChatMessage>? Messages { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ChatMessage> Messages { get; set; }
#endif
        /// <summary>Represents details about an online meeting. If the chat isn&apos;t associated with an online meeting, the property is empty. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.TeamworkOnlineMeetingInfo? OnlineMeetingInfo { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.TeamworkOnlineMeetingInfo OnlineMeetingInfo { get; set; }
#endif
        /// <summary>A collection of permissions granted to apps for the chat.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ResourceSpecificPermissionGrant>? PermissionGrants { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ResourceSpecificPermissionGrant> PermissionGrants { get; set; }
#endif
        /// <summary>A collection of all the pinned messages in the chat. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.PinnedChatMessageInfo>? PinnedMessages { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.PinnedChatMessageInfo> PinnedMessages { get; set; }
#endif
        /// <summary>A collection of all the tabs in the chat. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.TeamsTab>? Tabs { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.TeamsTab> Tabs { get; set; }
#endif
        /// <summary>The identifier of the tenant in which the chat was created. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId { get; set; }
#nullable restore
#else
        public string TenantId { get; set; }
#endif
        /// <summary>(Optional) Subject or topic for the chat. Only available for group chats.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Topic { get; set; }
#nullable restore
#else
        public string Topic { get; set; }
#endif
        /// <summary>Represents caller-specific information about the chat, such as the last message read date and time. This property is populated only when the request is made in a delegated context.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.ChatViewpoint? Viewpoint { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.ChatViewpoint Viewpoint { get; set; }
#endif
        /// <summary>The URL for the chat in Microsoft Teams. The URL should be treated as an opaque blob, and not parsed. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebUrl { get; set; }
#nullable restore
#else
        public string WebUrl { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.Chat"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.Chat CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.Chat();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "chatType", n => { ChatType = n.GetEnumValue<global::ApiSdk.Models.ChatType>(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "installedApps", n => { InstalledApps = n.GetCollectionOfObjectValues<global::ApiSdk.Models.TeamsAppInstallation>(global::ApiSdk.Models.TeamsAppInstallation.CreateFromDiscriminatorValue)?.AsList(); } },
                { "lastMessagePreview", n => { LastMessagePreview = n.GetObjectValue<global::ApiSdk.Models.ChatMessageInfo>(global::ApiSdk.Models.ChatMessageInfo.CreateFromDiscriminatorValue); } },
                { "lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "members", n => { Members = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ConversationMember>(global::ApiSdk.Models.ConversationMember.CreateFromDiscriminatorValue)?.AsList(); } },
                { "messages", n => { Messages = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ChatMessage>(global::ApiSdk.Models.ChatMessage.CreateFromDiscriminatorValue)?.AsList(); } },
                { "onlineMeetingInfo", n => { OnlineMeetingInfo = n.GetObjectValue<global::ApiSdk.Models.TeamworkOnlineMeetingInfo>(global::ApiSdk.Models.TeamworkOnlineMeetingInfo.CreateFromDiscriminatorValue); } },
                { "permissionGrants", n => { PermissionGrants = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ResourceSpecificPermissionGrant>(global::ApiSdk.Models.ResourceSpecificPermissionGrant.CreateFromDiscriminatorValue)?.AsList(); } },
                { "pinnedMessages", n => { PinnedMessages = n.GetCollectionOfObjectValues<global::ApiSdk.Models.PinnedChatMessageInfo>(global::ApiSdk.Models.PinnedChatMessageInfo.CreateFromDiscriminatorValue)?.AsList(); } },
                { "tabs", n => { Tabs = n.GetCollectionOfObjectValues<global::ApiSdk.Models.TeamsTab>(global::ApiSdk.Models.TeamsTab.CreateFromDiscriminatorValue)?.AsList(); } },
                { "tenantId", n => { TenantId = n.GetStringValue(); } },
                { "topic", n => { Topic = n.GetStringValue(); } },
                { "viewpoint", n => { Viewpoint = n.GetObjectValue<global::ApiSdk.Models.ChatViewpoint>(global::ApiSdk.Models.ChatViewpoint.CreateFromDiscriminatorValue); } },
                { "webUrl", n => { WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<global::ApiSdk.Models.ChatType>("chatType", ChatType);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.TeamsAppInstallation>("installedApps", InstalledApps);
            writer.WriteObjectValue<global::ApiSdk.Models.ChatMessageInfo>("lastMessagePreview", LastMessagePreview);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ConversationMember>("members", Members);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ChatMessage>("messages", Messages);
            writer.WriteObjectValue<global::ApiSdk.Models.TeamworkOnlineMeetingInfo>("onlineMeetingInfo", OnlineMeetingInfo);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ResourceSpecificPermissionGrant>("permissionGrants", PermissionGrants);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.PinnedChatMessageInfo>("pinnedMessages", PinnedMessages);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.TeamsTab>("tabs", Tabs);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteStringValue("topic", Topic);
            writer.WriteObjectValue<global::ApiSdk.Models.ChatViewpoint>("viewpoint", Viewpoint);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
#pragma warning restore CS0618
