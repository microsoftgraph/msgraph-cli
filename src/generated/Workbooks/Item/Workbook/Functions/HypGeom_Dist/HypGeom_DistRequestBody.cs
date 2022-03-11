using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.HypGeom_Dist {
    public class HypGeom_DistRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Cumulative { get; set; }
        public Json NumberPop { get; set; }
        public Json NumberSample { get; set; }
        public Json PopulationS { get; set; }
        public Json SampleS { get; set; }
        /// <summary>
        /// Instantiates a new hypGeom_DistRequestBody and sets the default values.
        /// </summary>
        public HypGeom_DistRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static HypGeom_DistRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new HypGeom_DistRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"cumulative", (o,n) => { (o as HypGeom_DistRequestBody).Cumulative = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"numberPop", (o,n) => { (o as HypGeom_DistRequestBody).NumberPop = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"numberSample", (o,n) => { (o as HypGeom_DistRequestBody).NumberSample = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"populationS", (o,n) => { (o as HypGeom_DistRequestBody).PopulationS = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"sampleS", (o,n) => { (o as HypGeom_DistRequestBody).SampleS = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("cumulative", Cumulative);
            writer.WriteObjectValue<Json>("numberPop", NumberPop);
            writer.WriteObjectValue<Json>("numberSample", NumberSample);
            writer.WriteObjectValue<Json>("populationS", PopulationS);
            writer.WriteObjectValue<Json>("sampleS", SampleS);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
