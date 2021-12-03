using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class CertificateBasedAuthConfiguration : Entity, IParsable {
        /// <summary>Collection of certificate authorities which creates a trusted certificate chain.</summary>
        public List<CertificateAuthority> CertificateAuthorities { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"certificateAuthorities", (o,n) => { (o as CertificateBasedAuthConfiguration).CertificateAuthorities = n.GetCollectionOfObjectValues<CertificateAuthority>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<CertificateAuthority>("certificateAuthorities", CertificateAuthorities);
        }
    }
}
