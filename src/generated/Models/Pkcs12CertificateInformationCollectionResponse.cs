using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class Pkcs12CertificateInformationCollectionResponse : BaseCollectionPaginationCountResponse, IParsable {
        /// <summary>The value property</summary>
        public List<Pkcs12CertificateInformation> Value { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Pkcs12CertificateInformationCollectionResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Pkcs12CertificateInformationCollectionResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"value", n => { Value = n.GetCollectionOfObjectValues<Pkcs12CertificateInformation>(Pkcs12CertificateInformation.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Pkcs12CertificateInformation>("value", Value);
        }
    }
}
