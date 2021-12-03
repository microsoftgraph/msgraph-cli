using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class CallRoute : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public IdentitySet Final { get; set; }
        public IdentitySet Original { get; set; }
        /// <summary>Possible values are: forwarded, lookup, selfFork.</summary>
        public RoutingType? RoutingType { get; set; }
        /// <summary>
        /// Instantiates a new callRoute and sets the default values.
        /// </summary>
        public CallRoute() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"final", (o,n) => { (o as CallRoute).Final = n.GetObjectValue<IdentitySet>(); } },
                {"original", (o,n) => { (o as CallRoute).Original = n.GetObjectValue<IdentitySet>(); } },
                {"routingType", (o,n) => { (o as CallRoute).RoutingType = n.GetEnumValue<RoutingType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<IdentitySet>("final", Final);
            writer.WriteObjectValue<IdentitySet>("original", Original);
            writer.WriteEnumValue<RoutingType>("routingType", RoutingType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
