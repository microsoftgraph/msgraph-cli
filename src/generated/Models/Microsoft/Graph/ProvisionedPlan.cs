using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ProvisionedPlan : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>For example, 'Enabled'.</summary>
        public string CapabilityStatus { get; set; }
        /// <summary>For example, 'Success'.</summary>
        public string ProvisioningStatus { get; set; }
        /// <summary>The name of the service; for example, 'AccessControlS2S'</summary>
        public string Service { get; set; }
        /// <summary>
        /// Instantiates a new provisionedPlan and sets the default values.
        /// </summary>
        public ProvisionedPlan() {
            AdditionalData = new Dictionary<string, object>();
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
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"capabilityStatus", (o,n) => { (o as ProvisionedPlan).CapabilityStatus = n.GetStringValue(); } },
                {"provisioningStatus", (o,n) => { (o as ProvisionedPlan).ProvisioningStatus = n.GetStringValue(); } },
                {"service", (o,n) => { (o as ProvisionedPlan).Service = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("capabilityStatus", CapabilityStatus);
            writer.WriteStringValue("provisioningStatus", ProvisioningStatus);
            writer.WriteStringValue("service", Service);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
