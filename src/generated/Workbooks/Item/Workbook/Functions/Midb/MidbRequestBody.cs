using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.Midb {
    public class MidbRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json NumBytes { get; set; }
        public Json StartNum { get; set; }
        public Json Text { get; set; }
        /// <summary>
        /// Instantiates a new midbRequestBody and sets the default values.
        /// </summary>
        public MidbRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static MidbRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MidbRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"numBytes", (o,n) => { (o as MidbRequestBody).NumBytes = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"startNum", (o,n) => { (o as MidbRequestBody).StartNum = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"text", (o,n) => { (o as MidbRequestBody).Text = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("numBytes", NumBytes);
            writer.WriteObjectValue<Json>("startNum", StartNum);
            writer.WriteObjectValue<Json>("text", Text);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
