using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Restore {
    public class RestoreRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string Name { get; set; }
        public ItemReference ParentReference { get; set; }
        /// <summary>
        /// Instantiates a new restoreRequestBody and sets the default values.
        /// </summary>
        public RestoreRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static RestoreRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RestoreRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"name", (o,n) => { (o as RestoreRequestBody).Name = n.GetStringValue(); } },
                {"parentReference", (o,n) => { (o as RestoreRequestBody).ParentReference = n.GetObjectValue<ItemReference>(ItemReference.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<ItemReference>("parentReference", ParentReference);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
