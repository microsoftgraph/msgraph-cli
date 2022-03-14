using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.Days360 {
    public class Days360RequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json EndDate { get; set; }
        public Json Method { get; set; }
        public Json StartDate { get; set; }
        /// <summary>
        /// Instantiates a new days360RequestBody and sets the default values.
        /// </summary>
        public Days360RequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static Days360RequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Days360RequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"endDate", (o,n) => { (o as Days360RequestBody).EndDate = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"method", (o,n) => { (o as Days360RequestBody).Method = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"startDate", (o,n) => { (o as Days360RequestBody).StartDate = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("endDate", EndDate);
            writer.WriteObjectValue<Json>("method", Method);
            writer.WriteObjectValue<Json>("startDate", StartDate);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
