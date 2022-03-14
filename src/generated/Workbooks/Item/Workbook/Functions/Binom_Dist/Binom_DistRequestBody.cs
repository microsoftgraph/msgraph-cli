using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.Binom_Dist {
    public class Binom_DistRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Cumulative { get; set; }
        public Json NumberS { get; set; }
        public Json ProbabilityS { get; set; }
        public Json Trials { get; set; }
        /// <summary>
        /// Instantiates a new binom_DistRequestBody and sets the default values.
        /// </summary>
        public Binom_DistRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static Binom_DistRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Binom_DistRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"cumulative", (o,n) => { (o as Binom_DistRequestBody).Cumulative = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"numberS", (o,n) => { (o as Binom_DistRequestBody).NumberS = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"probabilityS", (o,n) => { (o as Binom_DistRequestBody).ProbabilityS = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"trials", (o,n) => { (o as Binom_DistRequestBody).Trials = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("cumulative", Cumulative);
            writer.WriteObjectValue<Json>("numberS", NumberS);
            writer.WriteObjectValue<Json>("probabilityS", ProbabilityS);
            writer.WriteObjectValue<Json>("trials", Trials);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
