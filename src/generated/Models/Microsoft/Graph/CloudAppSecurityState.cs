using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class CloudAppSecurityState : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Destination IP Address of the connection to the cloud application/service.</summary>
        public string DestinationServiceIp { get; set; }
        /// <summary>Cloud application/service name (for example 'Salesforce', 'DropBox', etc.).</summary>
        public string DestinationServiceName { get; set; }
        /// <summary>Provider-generated/calculated risk score of the Cloud Application/Service. Recommended value range of 0-1, which equates to a percentage.</summary>
        public string RiskScore { get; set; }
        /// <summary>
        /// Instantiates a new cloudAppSecurityState and sets the default values.
        /// </summary>
        public CloudAppSecurityState() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"destinationServiceIp", (o,n) => { (o as CloudAppSecurityState).DestinationServiceIp = n.GetStringValue(); } },
                {"destinationServiceName", (o,n) => { (o as CloudAppSecurityState).DestinationServiceName = n.GetStringValue(); } },
                {"riskScore", (o,n) => { (o as CloudAppSecurityState).RiskScore = n.GetStringValue(); } },
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
            writer.WriteStringValue("riskScore", RiskScore);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
