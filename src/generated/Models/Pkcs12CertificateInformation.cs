using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class Pkcs12CertificateInformation : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Represents whether the certificate is the active certificate to be used for calling the API connector. The active certificate is the most recently uploaded certificate which is not yet expired but whose notBefore time is in the past.</summary>
        public bool? IsActive { get; set; }
        /// <summary>The certificate&apos;s expiry. This value is a NumericDate as defined in RFC 7519 (A JSON numeric value representing the number of seconds from 1970-01-01T00:00:00Z UTC until the specified UTC date/time, ignoring leap seconds.)</summary>
        public long? NotAfter { get; set; }
        /// <summary>The certificate&apos;s issue time (not before). This value is a NumericDate as defined in RFC 7519 (A JSON numeric value representing the number of seconds from 1970-01-01T00:00:00Z UTC until the specified UTC date/time, ignoring leap seconds.)</summary>
        public long? NotBefore { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The certificate thumbprint.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Thumbprint { get; set; }
#nullable restore
#else
        public string Thumbprint { get; set; }
#endif
        /// <summary>
        /// Instantiates a new pkcs12CertificateInformation and sets the default values.
        /// </summary>
        public Pkcs12CertificateInformation() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Pkcs12CertificateInformation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Pkcs12CertificateInformation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"isActive", n => { IsActive = n.GetBoolValue(); } },
                {"notAfter", n => { NotAfter = n.GetLongValue(); } },
                {"notBefore", n => { NotBefore = n.GetLongValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"thumbprint", n => { Thumbprint = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isActive", IsActive);
            writer.WriteLongValue("notAfter", NotAfter);
            writer.WriteLongValue("notBefore", NotBefore);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("thumbprint", Thumbprint);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
