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
        public List<TeamsAppInstallation> InstalledApps { get; set; }
        /// <summary>Date and time at which the chat was renamed or list of members were last changed. Read-only.</summary>
        public DateTimeOffset? LastUpdatedDateTime { get; set; }
        /// <summary>A collection of all the members in the chat. Nullable.</summary>
        public List<ConversationMember> Members { get; set; }
        /// <summary>A collection of all the messages in the chat. Nullable.</summary>
        public List<ChatMessage> Messages { get; set; }
        public List<TeamsTab> Tabs { get; set; }
        /// <summary>(Optional) Subject or topic for the chat. Only available for group chats.</summary>
        public string Topic { get; set; }
        /// <summary>The URL for the chat in Microsoft Teams. The URL should be treated as an opaque blob, and not parsed. Read-only.</summary>
        public string WebUrl { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Chat CreateFromDiscriminatorValue(IParseNode parseNode) {
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
                {"installedApps", (o,n) => { (o as Chat).InstalledApps = n.GetCollectionOfObjectValues<TeamsAppInstallation>(TeamsAppInstallation.CreateFromDiscriminatorValue).ToList(); } },
                {"lastUpdatedDateTime", (o,n) => { (o as Chat).LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"members", (o,n) => { (o as Chat).Members = n.GetCollectionOfObjectValues<ConversationMember>(ConversationMember.CreateFromDiscriminatorValue).ToList(); } },
                {"messages", (o,n) => { (o as Chat).Messages = n.GetCollectionOfObjectValues<ChatMessage>(ChatMessage.CreateFromDiscriminatorValue).ToList(); } },
                {"tabs", (o,n) => { (o as Chat).Tabs = n.GetCollectionOfObjectValues<TeamsTab>(TeamsTab.CreateFromDiscriminatorValue).ToList(); } },
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
            writer.WriteCollectionOfObjectValues<TeamsAppInstallation>("installedApps", InstalledApps);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteCollectionOfObjectValues<ConversationMember>("members", Members);
            writer.WriteCollectionOfObjectValues<ChatMessage>("messages", Messages);
            writer.WriteCollectionOfObjectValues<TeamsTab>("tabs", Tabs);
            writer.WriteStringValue("topic", Topic);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
