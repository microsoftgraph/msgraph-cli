using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the auditLogRoot singleton.</summary>
    public class Channel : Entity, IParsable {
        /// <summary>Read only. Timestamp at which the channel was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Optional textual description for the channel.</summary>
        public string Description { get; set; }
        /// <summary>Channel name as it will appear to the user in Microsoft Teams.</summary>
        public string DisplayName { get; set; }
        /// <summary>The email address for sending messages to the channel. Read-only.</summary>
        public string Email { get; set; }
        /// <summary>Metadata for the location where the channel&apos;s files are stored.</summary>
        public DriveItem FilesFolder { get; set; }
        /// <summary>Indicates whether the channel should automatically be marked &apos;favorite&apos; for all members of the team. Can only be set programmatically with Create team. Default: false.</summary>
        public bool? IsFavoriteByDefault { get; set; }
        /// <summary>A collection of membership records associated with the channel.</summary>
        public List<ConversationMember> Members { get; set; }
        /// <summary>The type of the channel. Can be set during creation and can&apos;t be changed. The possible values are: standard, private, unknownFutureValue, shared. The default value is standard. Note that you must use the Prefer: include-unknown-enum-members request header to get the following value in this evolvable enum: shared.</summary>
        public ChannelMembershipType? MembershipType { get; set; }
        /// <summary>A collection of all the messages in the channel. A navigation property. Nullable.</summary>
        public List<ChatMessage> Messages { get; set; }
        /// <summary>A collection of teams with which a channel is shared.</summary>
        public List<SharedWithChannelTeamInfo> SharedWithTeams { get; set; }
        /// <summary>A collection of all the tabs in the channel. A navigation property.</summary>
        public List<TeamsTab> Tabs { get; set; }
        /// <summary>The ID of the Azure Active Directory tenant.</summary>
        public string TenantId { get; set; }
        /// <summary>A hyperlink that will go to the channel in Microsoft Teams. This is the URL that you get when you right-click a channel in Microsoft Teams and select Get link to channel. This URL should be treated as an opaque blob, and not parsed. Read-only.</summary>
        public string WebUrl { get; set; }
        /// <summary>
        /// Instantiates a new channel and sets the default values.
        /// </summary>
        public Channel() : base() {
            OdataType = "#microsoft.graph.channel";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Channel CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Channel();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"email", n => { Email = n.GetStringValue(); } },
                {"filesFolder", n => { FilesFolder = n.GetObjectValue<DriveItem>(DriveItem.CreateFromDiscriminatorValue); } },
                {"isFavoriteByDefault", n => { IsFavoriteByDefault = n.GetBoolValue(); } },
                {"members", n => { Members = n.GetCollectionOfObjectValues<ConversationMember>(ConversationMember.CreateFromDiscriminatorValue).ToList(); } },
                {"membershipType", n => { MembershipType = n.GetEnumValue<ChannelMembershipType>(); } },
                {"messages", n => { Messages = n.GetCollectionOfObjectValues<ChatMessage>(ChatMessage.CreateFromDiscriminatorValue).ToList(); } },
                {"sharedWithTeams", n => { SharedWithTeams = n.GetCollectionOfObjectValues<SharedWithChannelTeamInfo>(SharedWithChannelTeamInfo.CreateFromDiscriminatorValue).ToList(); } },
                {"tabs", n => { Tabs = n.GetCollectionOfObjectValues<TeamsTab>(TeamsTab.CreateFromDiscriminatorValue).ToList(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
                {"webUrl", n => { WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("email", Email);
            writer.WriteObjectValue<DriveItem>("filesFolder", FilesFolder);
            writer.WriteBoolValue("isFavoriteByDefault", IsFavoriteByDefault);
            writer.WriteCollectionOfObjectValues<ConversationMember>("members", Members);
            writer.WriteEnumValue<ChannelMembershipType>("membershipType", MembershipType);
            writer.WriteCollectionOfObjectValues<ChatMessage>("messages", Messages);
            writer.WriteCollectionOfObjectValues<SharedWithChannelTeamInfo>("sharedWithTeams", SharedWithTeams);
            writer.WriteCollectionOfObjectValues<TeamsTab>("tabs", Tabs);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
