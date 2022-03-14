using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.Time {
    public class TimeRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Hour { get; set; }
        public Json Minute { get; set; }
        public Json Second { get; set; }
        /// <summary>
        /// Instantiates a new timeRequestBody and sets the default values.
        /// </summary>
        public TimeRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TimeRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TimeRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"hour", (o,n) => { (o as TimeRequestBody).Hour = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"minute", (o,n) => { (o as TimeRequestBody).Minute = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"second", (o,n) => { (o as TimeRequestBody).Second = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("hour", Hour);
            writer.WriteObjectValue<Json>("minute", Minute);
            writer.WriteObjectValue<Json>("second", Second);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
