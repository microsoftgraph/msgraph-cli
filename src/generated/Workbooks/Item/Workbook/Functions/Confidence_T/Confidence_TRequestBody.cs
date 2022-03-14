using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.Confidence_T {
    public class Confidence_TRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Alpha { get; set; }
        public Json Size { get; set; }
        public Json StandardDev { get; set; }
        /// <summary>
        /// Instantiates a new confidence_TRequestBody and sets the default values.
        /// </summary>
        public Confidence_TRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static Confidence_TRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Confidence_TRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"alpha", (o,n) => { (o as Confidence_TRequestBody).Alpha = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"size", (o,n) => { (o as Confidence_TRequestBody).Size = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"standardDev", (o,n) => { (o as Confidence_TRequestBody).StandardDev = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("alpha", Alpha);
            writer.WriteObjectValue<Json>("size", Size);
            writer.WriteObjectValue<Json>("standardDev", StandardDev);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
