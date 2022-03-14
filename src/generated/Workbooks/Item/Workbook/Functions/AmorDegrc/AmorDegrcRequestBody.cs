using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.AmorDegrc {
    public class AmorDegrcRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Basis { get; set; }
        public Json Cost { get; set; }
        public Json DatePurchased { get; set; }
        public Json FirstPeriod { get; set; }
        public Json Period { get; set; }
        public Json Rate { get; set; }
        public Json Salvage { get; set; }
        /// <summary>
        /// Instantiates a new amorDegrcRequestBody and sets the default values.
        /// </summary>
        public AmorDegrcRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AmorDegrcRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AmorDegrcRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"basis", (o,n) => { (o as AmorDegrcRequestBody).Basis = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"cost", (o,n) => { (o as AmorDegrcRequestBody).Cost = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"datePurchased", (o,n) => { (o as AmorDegrcRequestBody).DatePurchased = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"firstPeriod", (o,n) => { (o as AmorDegrcRequestBody).FirstPeriod = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"period", (o,n) => { (o as AmorDegrcRequestBody).Period = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"rate", (o,n) => { (o as AmorDegrcRequestBody).Rate = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"salvage", (o,n) => { (o as AmorDegrcRequestBody).Salvage = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("basis", Basis);
            writer.WriteObjectValue<Json>("cost", Cost);
            writer.WriteObjectValue<Json>("datePurchased", DatePurchased);
            writer.WriteObjectValue<Json>("firstPeriod", FirstPeriod);
            writer.WriteObjectValue<Json>("period", Period);
            writer.WriteObjectValue<Json>("rate", Rate);
            writer.WriteObjectValue<Json>("salvage", Salvage);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
