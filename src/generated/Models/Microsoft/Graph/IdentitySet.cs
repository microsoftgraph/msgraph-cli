using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class IdentitySet : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Optional. The application associated with this action.</summary>
        public ApiSdk.Models.Microsoft.Graph.Identity Application { get; set; }
        /// <summary>Optional. The device associated with this action.</summary>
        public ApiSdk.Models.Microsoft.Graph.Identity Device { get; set; }
        /// <summary>Optional. The user associated with this action.</summary>
        public ApiSdk.Models.Microsoft.Graph.Identity User { get; set; }
        /// <summary>
        /// Instantiates a new identitySet and sets the default values.
        /// </summary>
        public IdentitySet() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"application", (o,n) => { (o as IdentitySet).Application = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Identity>(); } },
                {"device", (o,n) => { (o as IdentitySet).Device = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Identity>(); } },
                {"user", (o,n) => { (o as IdentitySet).User = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Identity>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Identity>("application", Application);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Identity>("device", Device);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Identity>("user", User);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
