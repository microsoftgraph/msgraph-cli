using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.Dproduct {
    public class DproductRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Criteria { get; set; }
        public Json Database { get; set; }
        public Json Field { get; set; }
        /// <summary>
        /// Instantiates a new dproductRequestBody and sets the default values.
        /// </summary>
        public DproductRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DproductRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DproductRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"criteria", (o,n) => { (o as DproductRequestBody).Criteria = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"database", (o,n) => { (o as DproductRequestBody).Database = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"field", (o,n) => { (o as DproductRequestBody).Field = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("criteria", Criteria);
            writer.WriteObjectValue<Json>("database", Database);
            writer.WriteObjectValue<Json>("field", Field);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
