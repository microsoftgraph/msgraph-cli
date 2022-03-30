using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ProvisionedIdentity : Identity, IParsable {
        /// <summary>Details of the identity.</summary>
        public ApiSdk.Models.Microsoft.Graph.DetailsInfo Details { get; set; }
        /// <summary>Type of identity that has been provisioned, such as 'user' or 'group'.</summary>
        public string IdentityType { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.ProvisionedIdentity CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ProvisionedIdentity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"details", (o,n) => { (o as ProvisionedIdentity).Details = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.DetailsInfo>(ApiSdk.Models.Microsoft.Graph.DetailsInfo.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.DetailsInfo>("details", Details);
            writer.WriteStringValue("identityType", IdentityType);
        }
    }
}
