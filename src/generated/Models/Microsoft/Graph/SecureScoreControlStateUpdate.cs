using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class SecureScoreControlStateUpdate : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Assigns the control to the user who will take the action.</summary>
        public string AssignedTo { get; set; }
        /// <summary>Provides optional comment about the control.</summary>
        public string Comment { get; set; }
        /// <summary>State of the control, which can be modified via a PATCH command (for example, ignored, thirdParty).</summary>
        public string State { get; set; }
        /// <summary>ID of the user who updated tenant state.</summary>
        public string UpdatedBy { get; set; }
        /// <summary>Time at which the control state was updated.</summary>
        public DateTimeOffset? UpdatedDateTime { get; set; }
        /// <summary>
        /// Instantiates a new secureScoreControlStateUpdate and sets the default values.
        /// </summary>
        public SecureScoreControlStateUpdate() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.SecureScoreControlStateUpdate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SecureScoreControlStateUpdate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"assignedTo", (o,n) => { (o as SecureScoreControlStateUpdate).AssignedTo = n.GetStringValue(); } },
                {"comment", (o,n) => { (o as SecureScoreControlStateUpdate).Comment = n.GetStringValue(); } },
                {"state", (o,n) => { (o as SecureScoreControlStateUpdate).State = n.GetStringValue(); } },
                {"updatedBy", (o,n) => { (o as SecureScoreControlStateUpdate).UpdatedBy = n.GetStringValue(); } },
                {"updatedDateTime", (o,n) => { (o as SecureScoreControlStateUpdate).UpdatedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("assignedTo", AssignedTo);
            writer.WriteStringValue("comment", Comment);
            writer.WriteStringValue("state", State);
            writer.WriteStringValue("updatedBy", UpdatedBy);
            writer.WriteDateTimeOffsetValue("updatedDateTime", UpdatedDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
