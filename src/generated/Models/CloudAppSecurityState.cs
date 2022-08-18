using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class CloudAppSecurityState : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Destination IP Address of the connection to the cloud application/service.</summary>
        public string DestinationServiceIp { get; set; }
        /// <summary>Cloud application/service name (for example &apos;Salesforce&apos;, &apos;DropBox&apos;, etc.).</summary>
        public string DestinationServiceName { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>Provider-generated/calculated risk score of the Cloud Application/Service. Recommended value range of 0-1, which equates to a percentage.</summary>
        public string RiskScore { get; set; }
        /// <summary>
        /// Instantiates a new cloudAppSecurityState and sets the default values.
        /// </summary>
        public CloudAppSecurityState() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.cloudAppSecurityState";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CloudAppSecurityState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudAppSecurityState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"destinationServiceIp", n => { DestinationServiceIp = n.GetStringValue(); } },
                {"destinationServiceName", n => { DestinationServiceName = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"riskScore", n => { RiskScore = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("destinationServiceIp", DestinationServiceIp);
            writer.WriteStringValue("destinationServiceName", DestinationServiceName);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("riskScore", RiskScore);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
