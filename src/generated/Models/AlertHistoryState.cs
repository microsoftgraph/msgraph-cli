using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class AlertHistoryState : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The appId property</summary>
        public string AppId { get; set; }
        /// <summary>The assignedTo property</summary>
        public string AssignedTo { get; set; }
        /// <summary>The comments property</summary>
        public List<string> Comments { get; set; }
        /// <summary>The feedback property</summary>
        public AlertFeedback? Feedback { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>The status property</summary>
        public AlertStatus? Status { get; set; }
        /// <summary>The updatedDateTime property</summary>
        public DateTimeOffset? UpdatedDateTime { get; set; }
        /// <summary>The user property</summary>
        public string User { get; set; }
        /// <summary>
        /// Instantiates a new alertHistoryState and sets the default values.
        /// </summary>
        public AlertHistoryState() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.alertHistoryState";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AlertHistoryState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AlertHistoryState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"appId", n => { AppId = n.GetStringValue(); } },
                {"assignedTo", n => { AssignedTo = n.GetStringValue(); } },
                {"comments", n => { Comments = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"feedback", n => { Feedback = n.GetEnumValue<AlertFeedback>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<AlertStatus>(); } },
                {"updatedDateTime", n => { UpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"user", n => { User = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("appId", AppId);
            writer.WriteStringValue("assignedTo", AssignedTo);
            writer.WriteCollectionOfPrimitiveValues<string>("comments", Comments);
            writer.WriteEnumValue<AlertFeedback>("feedback", Feedback);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<AlertStatus>("status", Status);
            writer.WriteDateTimeOffsetValue("updatedDateTime", UpdatedDateTime);
            writer.WriteStringValue("user", User);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
