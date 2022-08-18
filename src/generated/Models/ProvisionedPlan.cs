using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class ProvisionedPlan : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>For example, &apos;Enabled&apos;.</summary>
        public string CapabilityStatus { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>For example, &apos;Success&apos;.</summary>
        public string ProvisioningStatus { get; set; }
        /// <summary>The name of the service; for example, &apos;AccessControlS2S&apos;</summary>
        public string Service { get; set; }
        /// <summary>
        /// Instantiates a new provisionedPlan and sets the default values.
        /// </summary>
        public ProvisionedPlan() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.provisionedPlan";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ProvisionedPlan CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ProvisionedPlan();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"capabilityStatus", n => { CapabilityStatus = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"provisioningStatus", n => { ProvisioningStatus = n.GetStringValue(); } },
                {"service", n => { Service = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("capabilityStatus", CapabilityStatus);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("provisioningStatus", ProvisioningStatus);
            writer.WriteStringValue("service", Service);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
