using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Communications.Calls.Item.UpdateRecordingStatus {
    public class UpdateRecordingStatusRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string ClientContext { get; set; }
        public RecordingStatus? Status { get; set; }
        /// <summary>
        /// Instantiates a new updateRecordingStatusRequestBody and sets the default values.
        /// </summary>
        public UpdateRecordingStatusRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UpdateRecordingStatusRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UpdateRecordingStatusRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"clientContext", (o,n) => { (o as UpdateRecordingStatusRequestBody).ClientContext = n.GetStringValue(); } },
                {"status", (o,n) => { (o as UpdateRecordingStatusRequestBody).Status = n.GetEnumValue<RecordingStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("clientContext", ClientContext);
            writer.WriteEnumValue<RecordingStatus>("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
