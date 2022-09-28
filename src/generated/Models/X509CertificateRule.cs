using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class X509CertificateRule : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The identifier property</summary>
        public string Identifier { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>The x509CertificateAuthenticationMode property</summary>
        public ApiSdk.Models.X509CertificateAuthenticationMode? X509CertificateAuthenticationMode { get; set; }
        /// <summary>The x509CertificateRuleType property</summary>
        public ApiSdk.Models.X509CertificateRuleType? X509CertificateRuleType { get; set; }
        /// <summary>
        /// Instantiates a new x509CertificateRule and sets the default values.
        /// </summary>
        public X509CertificateRule() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.x509CertificateRule";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static X509CertificateRule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new X509CertificateRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"identifier", n => { Identifier = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"x509CertificateAuthenticationMode", n => { X509CertificateAuthenticationMode = n.GetEnumValue<X509CertificateAuthenticationMode>(); } },
                {"x509CertificateRuleType", n => { X509CertificateRuleType = n.GetEnumValue<X509CertificateRuleType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("identifier", Identifier);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<X509CertificateAuthenticationMode>("x509CertificateAuthenticationMode", X509CertificateAuthenticationMode);
            writer.WriteEnumValue<X509CertificateRuleType>("x509CertificateRuleType", X509CertificateRuleType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
