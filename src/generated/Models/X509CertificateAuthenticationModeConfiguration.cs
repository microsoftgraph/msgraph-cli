using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class X509CertificateAuthenticationModeConfiguration : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>The rules property</summary>
        public List<X509CertificateRule> Rules { get; set; }
        /// <summary>The x509CertificateAuthenticationDefaultMode property</summary>
        public X509CertificateAuthenticationMode? X509CertificateAuthenticationDefaultMode { get; set; }
        /// <summary>
        /// Instantiates a new x509CertificateAuthenticationModeConfiguration and sets the default values.
        /// </summary>
        public X509CertificateAuthenticationModeConfiguration() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.x509CertificateAuthenticationModeConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static X509CertificateAuthenticationModeConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new X509CertificateAuthenticationModeConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"rules", n => { Rules = n.GetCollectionOfObjectValues<X509CertificateRule>(X509CertificateRule.CreateFromDiscriminatorValue)?.ToList(); } },
                {"x509CertificateAuthenticationDefaultMode", n => { X509CertificateAuthenticationDefaultMode = n.GetEnumValue<X509CertificateAuthenticationMode>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<X509CertificateRule>("rules", Rules);
            writer.WriteEnumValue<X509CertificateAuthenticationMode>("x509CertificateAuthenticationDefaultMode", X509CertificateAuthenticationDefaultMode);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
