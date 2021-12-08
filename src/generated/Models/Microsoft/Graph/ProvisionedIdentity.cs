using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ProvisionedIdentity : Identity, IParsable {
        /// <summary>Details of the identity.</summary>
        public DetailsInfo Details { get; set; }
        /// <summary>Type of identity that has been provisioned, such as 'user' or 'group'.</summary>
        public string IdentityType { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"details", (o,n) => { (o as ProvisionedIdentity).Details = n.GetObjectValue<DetailsInfo>(); } },
                {"identityType", (o,n) => { (o as ProvisionedIdentity).IdentityType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<DetailsInfo>("details", Details);
            writer.WriteStringValue("identityType", IdentityType);
        }
    }
}
