using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.Ceiling_Math {
    public class Ceiling_MathRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Mode { get; set; }
        public Json Number { get; set; }
        public Json Significance { get; set; }
        /// <summary>
        /// Instantiates a new ceiling_MathRequestBody and sets the default values.
        /// </summary>
        public Ceiling_MathRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static Ceiling_MathRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Ceiling_MathRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"mode", (o,n) => { (o as Ceiling_MathRequestBody).Mode = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"number", (o,n) => { (o as Ceiling_MathRequestBody).Number = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"significance", (o,n) => { (o as Ceiling_MathRequestBody).Significance = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("mode", Mode);
            writer.WriteObjectValue<Json>("number", Number);
            writer.WriteObjectValue<Json>("significance", Significance);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
