using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Chat : Entity, IParsable {
        /// <summary>Specifies the type of chat. Possible values are: group, oneOnOne, meeting, unknownFutureValue.</summary>
        public ApiSdk.Models.Microsoft.Graph.ChatType? ChatType { get; set; }
        /// <summary>Date and time at which the chat was created. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>A collection of all the apps in the chat. Nullable.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.TeamsAppInstallation> InstalledApps { get; set; }
        /// <summary>Date and time at which the chat was renamed or list of members were last changed. Read-only.</summary>
        public DateTimeOffset? LastUpdatedDateTime { get; set; }
        /// <summary>A collection of all the members in the chat. Nullable.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.ConversationMember> Members { get; set; }
        /// <summary>A collection of all the messages in the chat. Nullable.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.ChatMessage> Messages { get; set; }
        /// <summary>Represents details about an online meeting. If the chat isn't associated with an online meeting, the property is empty. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.TeamworkOnlineMeetingInfo OnlineMeetingInfo { get; set; }
        /// <summary>A collection of all the tabs in the chat. Nullable.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.TeamsTab> Tabs { get; set; }
        /// <summary>The identifier of the tenant in which the chat was created. Read-only.</summary>
        public string TenantId { get; set; }
        /// <summary>(Optional) Subject or topic for the chat. Only available for group chats.</summary>
        public string Topic { get; set; }
        /// <summary>The URL for the chat in Microsoft Teams. The URL should be treated as an opaque blob, and not parsed. Read-only.</summary>
        public string WebUrl { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.Chat CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Chat();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"chatType", (o,n) => { (o as Chat).ChatType = n.GetEnumValue<ChatType>(); } },
                {"createdDateTime", (o,n) => { (o as Chat).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"installedApps", (o,n) => { (o as Chat).InstalledApps = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.TeamsAppInstallation>(ApiSdk.Models.Microsoft.Graph.TeamsAppInstallation.CreateFromDiscriminatorValue).ToList(); } },
                {"lastUpdatedDateTime", (o,n) => { (o as Chat).LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"members", (o,n) => { (o as Chat).Members = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ConversationMember>(ApiSdk.Models.Microsoft.Graph.ConversationMember.CreateFromDiscriminatorValue).ToList(); } },
                {"messages", (o,n) => { (o as Chat).Messages = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ChatMessage>(ApiSdk.Models.Microsoft.Graph.ChatMessage.CreateFromDiscriminatorValue).ToList(); } },
                {"onlineMeetingInfo", (o,n) => { (o as Chat).OnlineMeetingInfo = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.TeamworkOnlineMeetingInfo>(ApiSdk.Models.Microsoft.Graph.TeamworkOnlineMeetingInfo.CreateFromDiscriminatorValue); } },
                {"tabs", (o,n) => { (o as Chat).Tabs = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.TeamsTab>(ApiSdk.Models.Microsoft.Graph.TeamsTab.CreateFromDiscriminatorValue).ToList(); } },
                {"tenantId", (o,n) => { (o as Chat).TenantId = n.GetStringValue(); } },
                {"topic", (o,n) => { (o as Chat).Topic = n.GetStringValue(); } },
                {"webUrl", (o,n) => { (o as Chat).WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<ChatType>("chatType", ChatType);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.TeamsAppInstallation>("installedApps", InstalledApps);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ConversationMember>("members", Members);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ChatMessage>("messages", Messages);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.TeamworkOnlineMeetingInfo>("onlineMeetingInfo", OnlineMeetingInfo);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.TeamsTab>("tabs", Tabs);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteStringValue("topic", Topic);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
