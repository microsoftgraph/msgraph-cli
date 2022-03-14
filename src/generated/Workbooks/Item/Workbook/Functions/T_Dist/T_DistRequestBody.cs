using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.T_Dist {
    public class T_DistRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Cumulative { get; set; }
        public Json DegFreedom { get; set; }
        public Json X { get; set; }
        /// <summary>
        /// Instantiates a new t_DistRequestBody and sets the default values.
        /// </summary>
        public T_DistRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static T_DistRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new T_DistRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"cumulative", (o,n) => { (o as T_DistRequestBody).Cumulative = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"degFreedom", (o,n) => { (o as T_DistRequestBody).DegFreedom = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"x", (o,n) => { (o as T_DistRequestBody).X = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("cumulative", Cumulative);
            writer.WriteObjectValue<Json>("degFreedom", DegFreedom);
            writer.WriteObjectValue<Json>("x", X);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
