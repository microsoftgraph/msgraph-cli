using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.Vdb {
    public class VdbRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Cost { get; set; }
        public Json EndPeriod { get; set; }
        public Json Factor { get; set; }
        public Json Life { get; set; }
        public Json NoSwitch { get; set; }
        public Json Salvage { get; set; }
        public Json StartPeriod { get; set; }
        /// <summary>
        /// Instantiates a new vdbRequestBody and sets the default values.
        /// </summary>
        public VdbRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static VdbRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VdbRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"cost", (o,n) => { (o as VdbRequestBody).Cost = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"endPeriod", (o,n) => { (o as VdbRequestBody).EndPeriod = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"factor", (o,n) => { (o as VdbRequestBody).Factor = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"life", (o,n) => { (o as VdbRequestBody).Life = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"noSwitch", (o,n) => { (o as VdbRequestBody).NoSwitch = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"salvage", (o,n) => { (o as VdbRequestBody).Salvage = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"startPeriod", (o,n) => { (o as VdbRequestBody).StartPeriod = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("cost", Cost);
            writer.WriteObjectValue<Json>("endPeriod", EndPeriod);
            writer.WriteObjectValue<Json>("factor", Factor);
            writer.WriteObjectValue<Json>("life", Life);
            writer.WriteObjectValue<Json>("noSwitch", NoSwitch);
            writer.WriteObjectValue<Json>("salvage", Salvage);
            writer.WriteObjectValue<Json>("startPeriod", StartPeriod);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
