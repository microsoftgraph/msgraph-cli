using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.Norm_Dist {
    public class Norm_DistRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Cumulative { get; set; }
        public Json Mean { get; set; }
        public Json StandardDev { get; set; }
        public Json X { get; set; }
        /// <summary>
        /// Instantiates a new norm_DistRequestBody and sets the default values.
        /// </summary>
        public Norm_DistRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static Norm_DistRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Norm_DistRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"cumulative", (o,n) => { (o as Norm_DistRequestBody).Cumulative = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"mean", (o,n) => { (o as Norm_DistRequestBody).Mean = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"standardDev", (o,n) => { (o as Norm_DistRequestBody).StandardDev = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"x", (o,n) => { (o as Norm_DistRequestBody).X = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("cumulative", Cumulative);
            writer.WriteObjectValue<Json>("mean", Mean);
            writer.WriteObjectValue<Json>("standardDev", StandardDev);
            writer.WriteObjectValue<Json>("x", X);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
