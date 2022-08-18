using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class CrossTenantAccessPolicyInboundTrust : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Specifies whether compliant devices from external Azure AD organizations are trusted.</summary>
        public bool? IsCompliantDeviceAccepted { get; set; }
        /// <summary>Specifies whether hybrid Azure AD joined devices from external Azure AD organizations are trusted.</summary>
        public bool? IsHybridAzureADJoinedDeviceAccepted { get; set; }
        /// <summary>Specifies whether MFA from external Azure AD organizations is trusted.</summary>
        public bool? IsMfaAccepted { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>
        /// Instantiates a new crossTenantAccessPolicyInboundTrust and sets the default values.
        /// </summary>
        public CrossTenantAccessPolicyInboundTrust() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.crossTenantAccessPolicyInboundTrust";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CrossTenantAccessPolicyInboundTrust CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CrossTenantAccessPolicyInboundTrust();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"isCompliantDeviceAccepted", n => { IsCompliantDeviceAccepted = n.GetBoolValue(); } },
                {"isHybridAzureADJoinedDeviceAccepted", n => { IsHybridAzureADJoinedDeviceAccepted = n.GetBoolValue(); } },
                {"isMfaAccepted", n => { IsMfaAccepted = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isCompliantDeviceAccepted", IsCompliantDeviceAccepted);
            writer.WriteBoolValue("isHybridAzureADJoinedDeviceAccepted", IsHybridAzureADJoinedDeviceAccepted);
            writer.WriteBoolValue("isMfaAccepted", IsMfaAccepted);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
