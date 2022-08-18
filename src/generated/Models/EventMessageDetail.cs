using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class EventMessageDetail : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>
        /// Instantiates a new eventMessageDetail and sets the default values.
        /// </summary>
        public EventMessageDetail() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.eventMessageDetail";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static EventMessageDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.callEndedEventMessageDetail" => new CallEndedEventMessageDetail(),
                "#microsoft.graph.callRecordingEventMessageDetail" => new CallRecordingEventMessageDetail(),
                "#microsoft.graph.callStartedEventMessageDetail" => new CallStartedEventMessageDetail(),
                "#microsoft.graph.callTranscriptEventMessageDetail" => new CallTranscriptEventMessageDetail(),
                "#microsoft.graph.channelAddedEventMessageDetail" => new ChannelAddedEventMessageDetail(),
                "#microsoft.graph.channelDeletedEventMessageDetail" => new ChannelDeletedEventMessageDetail(),
                "#microsoft.graph.channelDescriptionUpdatedEventMessageDetail" => new ChannelDescriptionUpdatedEventMessageDetail(),
                "#microsoft.graph.channelRenamedEventMessageDetail" => new ChannelRenamedEventMessageDetail(),
                "#microsoft.graph.channelSetAsFavoriteByDefaultEventMessageDetail" => new ChannelSetAsFavoriteByDefaultEventMessageDetail(),
                "#microsoft.graph.channelUnsetAsFavoriteByDefaultEventMessageDetail" => new ChannelUnsetAsFavoriteByDefaultEventMessageDetail(),
                "#microsoft.graph.chatRenamedEventMessageDetail" => new ChatRenamedEventMessageDetail(),
                "#microsoft.graph.conversationMemberRoleUpdatedEventMessageDetail" => new ConversationMemberRoleUpdatedEventMessageDetail(),
                "#microsoft.graph.meetingPolicyUpdatedEventMessageDetail" => new MeetingPolicyUpdatedEventMessageDetail(),
                "#microsoft.graph.membersAddedEventMessageDetail" => new MembersAddedEventMessageDetail(),
                "#microsoft.graph.membersDeletedEventMessageDetail" => new MembersDeletedEventMessageDetail(),
                "#microsoft.graph.membersJoinedEventMessageDetail" => new MembersJoinedEventMessageDetail(),
                "#microsoft.graph.membersLeftEventMessageDetail" => new MembersLeftEventMessageDetail(),
                "#microsoft.graph.tabUpdatedEventMessageDetail" => new TabUpdatedEventMessageDetail(),
                "#microsoft.graph.teamArchivedEventMessageDetail" => new TeamArchivedEventMessageDetail(),
                "#microsoft.graph.teamCreatedEventMessageDetail" => new TeamCreatedEventMessageDetail(),
                "#microsoft.graph.teamDescriptionUpdatedEventMessageDetail" => new TeamDescriptionUpdatedEventMessageDetail(),
                "#microsoft.graph.teamJoiningDisabledEventMessageDetail" => new TeamJoiningDisabledEventMessageDetail(),
                "#microsoft.graph.teamJoiningEnabledEventMessageDetail" => new TeamJoiningEnabledEventMessageDetail(),
                "#microsoft.graph.teamRenamedEventMessageDetail" => new TeamRenamedEventMessageDetail(),
                "#microsoft.graph.teamsAppInstalledEventMessageDetail" => new TeamsAppInstalledEventMessageDetail(),
                "#microsoft.graph.teamsAppRemovedEventMessageDetail" => new TeamsAppRemovedEventMessageDetail(),
                "#microsoft.graph.teamsAppUpgradedEventMessageDetail" => new TeamsAppUpgradedEventMessageDetail(),
                "#microsoft.graph.teamUnarchivedEventMessageDetail" => new TeamUnarchivedEventMessageDetail(),
                _ => new EventMessageDetail(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
