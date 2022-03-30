using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AddIn : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string Id { get; set; }
        public List<ApiSdk.Models.Microsoft.Graph.KeyValue> Properties { get; set; }
        public string Type { get; set; }
        /// <summary>
        /// Instantiates a new addIn and sets the default values.
        /// </summary>
        public AddIn() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.AddIn CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AddIn();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"id", (o,n) => { (o as AddIn).Id = n.GetStringValue(); } },
                {"properties", (o,n) => { (o as AddIn).Properties = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.KeyValue>(ApiSdk.Models.Microsoft.Graph.KeyValue.CreateFromDiscriminatorValue).ToList(); } },
                {"type", (o,n) => { (o as AddIn).Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("id", Id);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.KeyValue>("properties", Properties);
            writer.WriteStringValue("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
