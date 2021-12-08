using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ProvisioningStatusInfo : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public ProvisioningErrorInfo ErrorInformation { get; set; }
        /// <summary>Possible values are: success, warning, failure, skipped, unknownFutureValue.</summary>
        public ProvisioningResult? Status { get; set; }
        /// <summary>
        /// Instantiates a new provisioningStatusInfo and sets the default values.
        /// </summary>
        public ProvisioningStatusInfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"errorInformation", (o,n) => { (o as ProvisioningStatusInfo).ErrorInformation = n.GetObjectValue<ProvisioningErrorInfo>(); } },
                {"status", (o,n) => { (o as ProvisioningStatusInfo).Status = n.GetEnumValue<ProvisioningResult>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ProvisioningErrorInfo>("errorInformation", ErrorInformation);
            writer.WriteEnumValue<ProvisioningResult>("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
