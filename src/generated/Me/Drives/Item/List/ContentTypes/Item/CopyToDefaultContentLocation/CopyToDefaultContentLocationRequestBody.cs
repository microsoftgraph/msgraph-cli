using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Me.Drives.Item.List.ContentTypes.Item.CopyToDefaultContentLocation {
    /// <summary>Provides operations to call the copyToDefaultContentLocation method.</summary>
    public class CopyToDefaultContentLocationRequestBody : IAdditionalDataHolder, IParsable {
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
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Me.Drives.Item.List.ContentTypes.Item.CopyToDefaultContentLocation.CopyToDefaultContentLocationRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CopyToDefaultContentLocationRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"destinationFileName", (o,n) => { (o as CopyToDefaultContentLocationRequestBody).DestinationFileName = n.GetStringValue(); } },
                {"sourceFile", (o,n) => { (o as CopyToDefaultContentLocationRequestBody).SourceFile = n.GetObjectValue<ItemReference>(ItemReference.CreateFromDiscriminatorValue); } },
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
