using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.WorkDay_Intl {
    public class WorkDay_IntlRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Days { get; set; }
        public Json Holidays { get; set; }
        public Json StartDate { get; set; }
        public Json Weekend { get; set; }
        /// <summary>
        /// Instantiates a new workDay_IntlRequestBody and sets the default values.
        /// </summary>
        public WorkDay_IntlRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"days", (o,n) => { (o as WorkDay_IntlRequestBody).Days = n.GetObjectValue<Json>(); } },
                {"holidays", (o,n) => { (o as WorkDay_IntlRequestBody).Holidays = n.GetObjectValue<Json>(); } },
                {"startDate", (o,n) => { (o as WorkDay_IntlRequestBody).StartDate = n.GetObjectValue<Json>(); } },
                {"weekend", (o,n) => { (o as WorkDay_IntlRequestBody).Weekend = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("days", Days);
            writer.WriteObjectValue<Json>("holidays", Holidays);
            writer.WriteObjectValue<Json>("startDate", StartDate);
            writer.WriteObjectValue<Json>("weekend", Weekend);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
