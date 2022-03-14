using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.CoupPcd {
    public class CoupPcdRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Basis { get; set; }
        public Json Frequency { get; set; }
        public Json Maturity { get; set; }
        public Json Settlement { get; set; }
        /// <summary>
        /// Instantiates a new coupPcdRequestBody and sets the default values.
        /// </summary>
        public CoupPcdRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CoupPcdRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CoupPcdRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"basis", (o,n) => { (o as CoupPcdRequestBody).Basis = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"frequency", (o,n) => { (o as CoupPcdRequestBody).Frequency = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"maturity", (o,n) => { (o as CoupPcdRequestBody).Maturity = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"settlement", (o,n) => { (o as CoupPcdRequestBody).Settlement = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("basis", Basis);
            writer.WriteObjectValue<Json>("frequency", Frequency);
            writer.WriteObjectValue<Json>("maturity", Maturity);
            writer.WriteObjectValue<Json>("settlement", Settlement);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
