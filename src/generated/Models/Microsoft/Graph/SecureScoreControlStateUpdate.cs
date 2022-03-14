using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class SecureScoreControlStateUpdate : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string AssignedTo { get; set; }
        public string Comment { get; set; }
        public string State { get; set; }
        public string UpdatedBy { get; set; }
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
        public static SecureScoreControlStateUpdate CreateFromDiscriminatorValue(IParseNode parseNode) {
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
