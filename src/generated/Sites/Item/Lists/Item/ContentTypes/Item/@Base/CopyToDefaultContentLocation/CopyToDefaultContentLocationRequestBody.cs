using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Sites.Item.Lists.Item.ContentTypes.Item.@Base.CopyToDefaultContentLocation {
    public class CopyToDefaultContentLocationRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string DestinationFileName { get; set; }
        public ItemReference SourceFile { get; set; }
        /// <summary>
        /// Instantiates a new copyToDefaultContentLocationRequestBody and sets the default values.
        /// </summary>
        public CopyToDefaultContentLocationRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"destinationFileName", (o,n) => { (o as CopyToDefaultContentLocationRequestBody).DestinationFileName = n.GetStringValue(); } },
                {"sourceFile", (o,n) => { (o as CopyToDefaultContentLocationRequestBody).SourceFile = n.GetObjectValue<ItemReference>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("destinationFileName", DestinationFileName);
            writer.WriteObjectValue<ItemReference>("sourceFile", SourceFile);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
