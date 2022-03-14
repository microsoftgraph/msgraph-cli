using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.Beta_Dist {
    public class Beta_DistRequestBody : IAdditionalDataHolder, IParsable {
        public Json A { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Alpha { get; set; }
        public Json B { get; set; }
        public Json Beta { get; set; }
        public Json Cumulative { get; set; }
        public Json X { get; set; }
        /// <summary>
        /// Instantiates a new beta_DistRequestBody and sets the default values.
        /// </summary>
        public Beta_DistRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static Beta_DistRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Beta_DistRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"a", (o,n) => { (o as Beta_DistRequestBody).A = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"alpha", (o,n) => { (o as Beta_DistRequestBody).Alpha = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"b", (o,n) => { (o as Beta_DistRequestBody).B = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"beta", (o,n) => { (o as Beta_DistRequestBody).Beta = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"cumulative", (o,n) => { (o as Beta_DistRequestBody).Cumulative = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"x", (o,n) => { (o as Beta_DistRequestBody).X = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("a", A);
            writer.WriteObjectValue<Json>("alpha", Alpha);
            writer.WriteObjectValue<Json>("b", B);
            writer.WriteObjectValue<Json>("beta", Beta);
            writer.WriteObjectValue<Json>("cumulative", Cumulative);
            writer.WriteObjectValue<Json>("x", X);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
