using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.T_Dist_2T {
    public class T_Dist_2TRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json DegFreedom { get; set; }
        public Json X { get; set; }
        /// <summary>
        /// Instantiates a new t_Dist_2TRequestBody and sets the default values.
        /// </summary>
        public T_Dist_2TRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static T_Dist_2TRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new T_Dist_2TRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"degFreedom", (o,n) => { (o as T_Dist_2TRequestBody).DegFreedom = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"x", (o,n) => { (o as T_Dist_2TRequestBody).X = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("degFreedom", DegFreedom);
            writer.WriteObjectValue<Json>("x", X);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
