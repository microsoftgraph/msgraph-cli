using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class ClientCertificateAuthentication : ApiAuthenticationConfigurationBase, IParsable {
        /// <summary>The list of certificates uploaded for this API connector.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Pkcs12CertificateInformation>? CertificateList { get; set; }
#nullable restore
#else
        public List<Pkcs12CertificateInformation> CertificateList { get; set; }
#endif
        /// <summary>
        /// Instantiates a new ClientCertificateAuthentication and sets the default values.
        /// </summary>
        public ClientCertificateAuthentication() : base() {
            OdataType = "#microsoft.graph.clientCertificateAuthentication";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ClientCertificateAuthentication CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ClientCertificateAuthentication();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"certificateList", n => { CertificateList = n.GetCollectionOfObjectValues<Pkcs12CertificateInformation>(Pkcs12CertificateInformation.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Pkcs12CertificateInformation>("certificateList", CertificateList);
        }
    }
}
