using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Team : Entity, IParsable {
        /// <summary>The collection of channels & messages associated with the team.</summary>
        public List<Channel> Channels { get; set; }
        /// <summary>An optional label. Typically describes the data or business sensitivity of the team. Must match one of a pre-configured set in the tenant's directory.</summary>
        public string Classification { get; set; }
        /// <summary>Timestamp at which the team was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>An optional description for the team. Maximum length: 1024 characters.</summary>
        public string Description { get; set; }
        /// <summary>The name of the team.</summary>
        public string DisplayName { get; set; }
        /// <summary>Settings to configure use of Giphy, memes, and stickers in the team.</summary>
        public TeamFunSettings FunSettings { get; set; }
        public ApiSdk.Models.Microsoft.Graph.Group Group { get; set; }
        /// <summary>Settings to configure whether guests can create, update, or delete channels in the team.</summary>
        public TeamGuestSettings GuestSettings { get; set; }
        /// <summary>The apps installed in this team.</summary>
        public List<TeamsAppInstallation> InstalledApps { get; set; }
        /// <summary>A unique ID for the team that has been used in a few places such as the audit log/Office 365 Management Activity API.</summary>
        public string InternalId { get; set; }
        /// <summary>Whether this team is in read-only mode.</summary>
        public bool? IsArchived { get; set; }
        /// <summary>Members and owners of the team.</summary>
        public List<ConversationMember> Members { get; set; }
        /// <summary>Settings to configure whether members can perform certain actions, for example, create channels and add bots, in the team.</summary>
        public TeamMemberSettings MemberSettings { get; set; }
        /// <summary>Settings to configure messaging and mentions in the team.</summary>
        public TeamMessagingSettings MessagingSettings { get; set; }
        /// <summary>The async operations that ran or are running on this team.</summary>
        public List<TeamsAsyncOperation> Operations { get; set; }
        /// <summary>The general channel for the team.</summary>
        public Channel PrimaryChannel { get; set; }
        /// <summary>The schedule of shifts for this team.</summary>
        public ApiSdk.Models.Microsoft.Graph.Schedule Schedule { get; set; }
        /// <summary>Optional. Indicates whether the team is intended for a particular use case.  Each team specialization has access to unique behaviors and experiences targeted to its use case.</summary>
        public TeamSpecialization? Specialization { get; set; }
        /// <summary>The template this team was created from. See available templates.</summary>
        public TeamsTemplate Template { get; set; }
        /// <summary>The visibility of the group and team. Defaults to Public.</summary>
        public TeamVisibilityType? Visibility { get; set; }
        /// <summary>A hyperlink that will go to the team in the Microsoft Teams client. This is the URL that you get when you right-click a team in the Microsoft Teams client and select Get link to team. This URL should be treated as an opaque blob, and not parsed.</summary>
        public string WebUrl { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Team CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Team();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"channels", (o,n) => { (o as Team).Channels = n.GetCollectionOfObjectValues<Channel>(Channel.CreateFromDiscriminatorValue).ToList(); } },
                {"classification", (o,n) => { (o as Team).Classification = n.GetStringValue(); } },
                {"createdDateTime", (o,n) => { (o as Team).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as Team).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as Team).DisplayName = n.GetStringValue(); } },
                {"funSettings", (o,n) => { (o as Team).FunSettings = n.GetObjectValue<TeamFunSettings>(TeamFunSettings.CreateFromDiscriminatorValue); } },
                {"group", (o,n) => { (o as Team).Group = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Group>(ApiSdk.Models.Microsoft.Graph.Group.CreateFromDiscriminatorValue); } },
                {"guestSettings", (o,n) => { (o as Team).GuestSettings = n.GetObjectValue<TeamGuestSettings>(TeamGuestSettings.CreateFromDiscriminatorValue); } },
                {"installedApps", (o,n) => { (o as Team).InstalledApps = n.GetCollectionOfObjectValues<TeamsAppInstallation>(TeamsAppInstallation.CreateFromDiscriminatorValue).ToList(); } },
                {"internalId", (o,n) => { (o as Team).InternalId = n.GetStringValue(); } },
                {"isArchived", (o,n) => { (o as Team).IsArchived = n.GetBoolValue(); } },
                {"members", (o,n) => { (o as Team).Members = n.GetCollectionOfObjectValues<ConversationMember>(ConversationMember.CreateFromDiscriminatorValue).ToList(); } },
                {"memberSettings", (o,n) => { (o as Team).MemberSettings = n.GetObjectValue<TeamMemberSettings>(TeamMemberSettings.CreateFromDiscriminatorValue); } },
                {"messagingSettings", (o,n) => { (o as Team).MessagingSettings = n.GetObjectValue<TeamMessagingSettings>(TeamMessagingSettings.CreateFromDiscriminatorValue); } },
                {"operations", (o,n) => { (o as Team).Operations = n.GetCollectionOfObjectValues<TeamsAsyncOperation>(TeamsAsyncOperation.CreateFromDiscriminatorValue).ToList(); } },
                {"primaryChannel", (o,n) => { (o as Team).PrimaryChannel = n.GetObjectValue<Channel>(Channel.CreateFromDiscriminatorValue); } },
                {"schedule", (o,n) => { (o as Team).Schedule = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Schedule>(ApiSdk.Models.Microsoft.Graph.Schedule.CreateFromDiscriminatorValue); } },
                {"specialization", (o,n) => { (o as Team).Specialization = n.GetEnumValue<TeamSpecialization>(); } },
                {"template", (o,n) => { (o as Team).Template = n.GetObjectValue<TeamsTemplate>(TeamsTemplate.CreateFromDiscriminatorValue); } },
                {"visibility", (o,n) => { (o as Team).Visibility = n.GetEnumValue<TeamVisibilityType>(); } },
                {"webUrl", (o,n) => { (o as Team).WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Channel>("channels", Channels);
            writer.WriteStringValue("classification", Classification);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<TeamFunSettings>("funSettings", FunSettings);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Group>("group", Group);
            writer.WriteObjectValue<TeamGuestSettings>("guestSettings", GuestSettings);
            writer.WriteCollectionOfObjectValues<TeamsAppInstallation>("installedApps", InstalledApps);
            writer.WriteStringValue("internalId", InternalId);
            writer.WriteBoolValue("isArchived", IsArchived);
            writer.WriteCollectionOfObjectValues<ConversationMember>("members", Members);
            writer.WriteObjectValue<TeamMemberSettings>("memberSettings", MemberSettings);
            writer.WriteObjectValue<TeamMessagingSettings>("messagingSettings", MessagingSettings);
            writer.WriteCollectionOfObjectValues<TeamsAsyncOperation>("operations", Operations);
            writer.WriteObjectValue<Channel>("primaryChannel", PrimaryChannel);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Schedule>("schedule", Schedule);
            writer.WriteEnumValue<TeamSpecialization>("specialization", Specialization);
            writer.WriteObjectValue<TeamsTemplate>("template", Template);
            writer.WriteEnumValue<TeamVisibilityType>("visibility", Visibility);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
