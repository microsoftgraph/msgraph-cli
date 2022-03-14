using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.AverageIf {
    public class AverageIfRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json AverageRange { get; set; }
        public Json Criteria { get; set; }
        public Json Range { get; set; }
        /// <summary>
        /// Instantiates a new averageIfRequestBody and sets the default values.
        /// </summary>
        public AverageIfRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AverageIfRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AverageIfRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"averageRange", (o,n) => { (o as AverageIfRequestBody).AverageRange = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"criteria", (o,n) => { (o as AverageIfRequestBody).Criteria = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"range", (o,n) => { (o as AverageIfRequestBody).Range = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("averageRange", AverageRange);
            writer.WriteObjectValue<Json>("criteria", Criteria);
            writer.WriteObjectValue<Json>("range", Range);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
