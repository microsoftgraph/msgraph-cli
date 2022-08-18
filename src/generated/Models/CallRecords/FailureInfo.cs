using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.CallRecords {
    public class FailureInfo : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>Classification of why a call or portion of a call failed.</summary>
        public string Reason { get; set; }
        /// <summary>The stage property</summary>
        public FailureStage? Stage { get; set; }
        /// <summary>
        /// Instantiates a new failureInfo and sets the default values.
        /// </summary>
        public FailureInfo() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.callRecords.failureInfo";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static FailureInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FailureInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"reason", n => { Reason = n.GetStringValue(); } },
                {"stage", n => { Stage = n.GetEnumValue<FailureStage>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("reason", Reason);
            writer.WriteEnumValue<FailureStage>("stage", Stage);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
