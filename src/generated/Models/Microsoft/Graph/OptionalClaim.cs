using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class OptionalClaim : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Additional properties of the claim. If a property exists in this collection, it modifies the behavior of the optional claim specified in the name property.</summary>
        public List<string> AdditionalProperties { get; set; }
        /// <summary>If the value is true, the claim specified by the client is necessary to ensure a smooth authorization experience for the specific task requested by the end user. The default value is false.</summary>
        public bool? Essential { get; set; }
        /// <summary>The name of the optional claim.</summary>
        public string Name { get; set; }
        /// <summary>The source (directory object) of the claim. There are predefined claims and user-defined claims from extension properties. If the source value is null, the claim is a predefined optional claim. If the source value is user, the value in the name property is the extension property from the user object.</summary>
        public string Source { get; set; }
        /// <summary>
        /// Instantiates a new optionalClaim and sets the default values.
        /// </summary>
        public OptionalClaim() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"additionalProperties", (o,n) => { (o as OptionalClaim).AdditionalProperties = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"essential", (o,n) => { (o as OptionalClaim).Essential = n.GetBoolValue(); } },
                {"name", (o,n) => { (o as OptionalClaim).Name = n.GetStringValue(); } },
                {"source", (o,n) => { (o as OptionalClaim).Source = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("additionalProperties", AdditionalProperties);
            writer.WriteBoolValue("essential", Essential);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("source", Source);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
