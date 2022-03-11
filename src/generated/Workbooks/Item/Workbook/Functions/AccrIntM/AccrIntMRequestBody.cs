using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.AccrIntM {
    public class AccrIntMRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Basis { get; set; }
        public Json Issue { get; set; }
        public Json Par { get; set; }
        public Json Rate { get; set; }
        public Json Settlement { get; set; }
        /// <summary>
        /// Instantiates a new accrIntMRequestBody and sets the default values.
        /// </summary>
        public AccrIntMRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AccrIntMRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccrIntMRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"basis", (o,n) => { (o as AccrIntMRequestBody).Basis = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"issue", (o,n) => { (o as AccrIntMRequestBody).Issue = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"par", (o,n) => { (o as AccrIntMRequestBody).Par = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"rate", (o,n) => { (o as AccrIntMRequestBody).Rate = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"settlement", (o,n) => { (o as AccrIntMRequestBody).Settlement = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("basis", Basis);
            writer.WriteObjectValue<Json>("issue", Issue);
            writer.WriteObjectValue<Json>("par", Par);
            writer.WriteObjectValue<Json>("rate", Rate);
            writer.WriteObjectValue<Json>("settlement", Settlement);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
