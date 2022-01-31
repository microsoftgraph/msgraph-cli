using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class PersonType : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The type of data source, such as Person.</summary>
        public string Class { get; set; }
        /// <summary>The secondary type of data source, such as OrganizationUser.</summary>
        public string Subclass { get; set; }
        /// <summary>
        /// Instantiates a new personType and sets the default values.
        /// </summary>
        public PersonType() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"class", (o,n) => { (o as PersonType).Class = n.GetStringValue(); } },
                {"subclass", (o,n) => { (o as PersonType).Subclass = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("class", Class);
            writer.WriteStringValue("subclass", Subclass);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
