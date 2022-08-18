using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class ConvertIdResult : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>An error object indicating the reason for the conversion failure. This value is not present if the conversion succeeded.</summary>
        public GenericError ErrorDetails { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>The identifier that was converted. This value is the original, un-converted identifier.</summary>
        public string SourceId { get; set; }
        /// <summary>The converted identifier. This value is not present if the conversion failed.</summary>
        public string TargetId { get; set; }
        /// <summary>
        /// Instantiates a new convertIdResult and sets the default values.
        /// </summary>
        public ConvertIdResult() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.convertIdResult";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ConvertIdResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConvertIdResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"errorDetails", n => { ErrorDetails = n.GetObjectValue<GenericError>(GenericError.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"sourceId", n => { SourceId = n.GetStringValue(); } },
                {"targetId", n => { TargetId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<GenericError>("errorDetails", ErrorDetails);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("sourceId", SourceId);
            writer.WriteStringValue("targetId", TargetId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
