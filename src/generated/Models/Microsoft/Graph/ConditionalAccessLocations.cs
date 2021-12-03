using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ConditionalAccessLocations : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Location IDs excluded from scope of policy.</summary>
        public List<string> ExcludeLocations { get; set; }
        /// <summary>Location IDs in scope of policy unless explicitly excluded, All, or AllTrusted.</summary>
        public List<string> IncludeLocations { get; set; }
        /// <summary>
        /// Instantiates a new conditionalAccessLocations and sets the default values.
        /// </summary>
        public ConditionalAccessLocations() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"excludeLocations", (o,n) => { (o as ConditionalAccessLocations).ExcludeLocations = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"includeLocations", (o,n) => { (o as ConditionalAccessLocations).IncludeLocations = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("excludeLocations", ExcludeLocations);
            writer.WriteCollectionOfPrimitiveValues<string>("includeLocations", IncludeLocations);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
