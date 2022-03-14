using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.Rate {
    public class RateRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Fv { get; set; }
        public Json Guess { get; set; }
        public Json Nper { get; set; }
        public Json Pmt { get; set; }
        public Json Pv { get; set; }
        public Json Type { get; set; }
        /// <summary>
        /// Instantiates a new rateRequestBody and sets the default values.
        /// </summary>
        public RateRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static RateRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RateRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"fv", (o,n) => { (o as RateRequestBody).Fv = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"guess", (o,n) => { (o as RateRequestBody).Guess = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"nper", (o,n) => { (o as RateRequestBody).Nper = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"pmt", (o,n) => { (o as RateRequestBody).Pmt = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"pv", (o,n) => { (o as RateRequestBody).Pv = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"type", (o,n) => { (o as RateRequestBody).Type = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("fv", Fv);
            writer.WriteObjectValue<Json>("guess", Guess);
            writer.WriteObjectValue<Json>("nper", Nper);
            writer.WriteObjectValue<Json>("pmt", Pmt);
            writer.WriteObjectValue<Json>("pv", Pv);
            writer.WriteObjectValue<Json>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
