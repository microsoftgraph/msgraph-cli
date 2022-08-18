using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class TeamDescriptionUpdatedEventMessageDetail : EventMessageDetail, IParsable {
        /// <summary>Initiator of the event.</summary>
        public IdentitySet Initiator { get; set; }
        /// <summary>The updated description for the team.</summary>
        public string TeamDescription { get; set; }
        /// <summary>Unique identifier of the team.</summary>
        public string TeamId { get; set; }
        /// <summary>
        /// Instantiates a new TeamDescriptionUpdatedEventMessageDetail and sets the default values.
        /// </summary>
        public TeamDescriptionUpdatedEventMessageDetail() : base() {
            OdataType = "#microsoft.graph.teamDescriptionUpdatedEventMessageDetail";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TeamDescriptionUpdatedEventMessageDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamDescriptionUpdatedEventMessageDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"initiator", n => { Initiator = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"teamDescription", n => { TeamDescription = n.GetStringValue(); } },
                {"teamId", n => { TeamId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<IdentitySet>("initiator", Initiator);
            writer.WriteStringValue("teamDescription", TeamDescription);
            writer.WriteStringValue("teamId", TeamId);
        }
    }
}
