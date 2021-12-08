using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.DirectoryObjects.GetByIds {
    public class GetByIdsRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<string> Ids { get; set; }
        public List<string> Types { get; set; }
        /// <summary>
        /// Instantiates a new getByIdsRequestBody and sets the default values.
        /// </summary>
        public GetByIdsRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"ids", (o,n) => { (o as GetByIdsRequestBody).Ids = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"types", (o,n) => { (o as GetByIdsRequestBody).Types = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("ids", Ids);
            writer.WriteCollectionOfPrimitiveValues<string>("types", Types);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
