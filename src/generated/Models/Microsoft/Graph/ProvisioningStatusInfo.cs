using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ProvisioningStatusInfo : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public ApiSdk.Models.Microsoft.Graph.ProvisioningErrorInfo ErrorInformation { get; set; }
        /// <summary>Possible values are: success, warning, failure, skipped, unknownFutureValue.</summary>
        public ProvisioningResult? Status { get; set; }
        /// <summary>
        /// Instantiates a new provisioningStatusInfo and sets the default values.
        /// </summary>
        public ProvisioningStatusInfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.ProvisioningStatusInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ProvisioningStatusInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"errorInformation", (o,n) => { (o as ProvisioningStatusInfo).ErrorInformation = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ProvisioningErrorInfo>(ApiSdk.Models.Microsoft.Graph.ProvisioningErrorInfo.CreateFromDiscriminatorValue); } },
                {"status", (o,n) => { (o as ProvisioningStatusInfo).Status = n.GetEnumValue<ProvisioningResult>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ProvisioningErrorInfo>("errorInformation", ErrorInformation);
            writer.WriteEnumValue<ProvisioningResult>("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
