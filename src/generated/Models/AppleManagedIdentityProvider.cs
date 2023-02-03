using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class AppleManagedIdentityProvider : IdentityProviderBase, IParsable {
        /// <summary>The certificate data, which is a long string of text from the certificate. Can be null.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CertificateData { get; set; }
#nullable restore
#else
        public string CertificateData { get; set; }
#endif
        /// <summary>The Apple developer identifier. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeveloperId { get; set; }
#nullable restore
#else
        public string DeveloperId { get; set; }
#endif
        /// <summary>The Apple key identifier. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? KeyId { get; set; }
#nullable restore
#else
        public string KeyId { get; set; }
#endif
        /// <summary>The Apple service identifier. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServiceId { get; set; }
#nullable restore
#else
        public string ServiceId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new AppleManagedIdentityProvider and sets the default values.
        /// </summary>
        public AppleManagedIdentityProvider() : base() {
            OdataType = "#microsoft.graph.appleManagedIdentityProvider";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AppleManagedIdentityProvider CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AppleManagedIdentityProvider();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"certificateData", n => { CertificateData = n.GetStringValue(); } },
                {"developerId", n => { DeveloperId = n.GetStringValue(); } },
                {"keyId", n => { KeyId = n.GetStringValue(); } },
                {"serviceId", n => { ServiceId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("certificateData", CertificateData);
            writer.WriteStringValue("developerId", DeveloperId);
            writer.WriteStringValue("keyId", KeyId);
            writer.WriteStringValue("serviceId", ServiceId);
        }
    }
}
