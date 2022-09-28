using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class CommsNotification : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The changeType property</summary>
        public ApiSdk.Models.ChangeType? ChangeType { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>URI of the resource that was changed.</summary>
        public string ResourceUrl { get; set; }
        /// <summary>
        /// Instantiates a new commsNotification and sets the default values.
        /// </summary>
        public CommsNotification() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.commsNotification";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CommsNotification CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CommsNotification();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"changeType", n => { ChangeType = n.GetEnumValue<ChangeType>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"resourceUrl", n => { ResourceUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<ChangeType>("changeType", ChangeType);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("resourceUrl", ResourceUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
