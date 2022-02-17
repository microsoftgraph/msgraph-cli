using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class WorkbookFilterCriteria : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string Color { get; set; }
        public string Criterion1 { get; set; }
        public string Criterion2 { get; set; }
        public string DynamicCriteria { get; set; }
        public string FilterOn { get; set; }
        public WorkbookIcon Icon { get; set; }
        public string Operator { get; set; }
        public Json Values { get; set; }
        /// <summary>
        /// Instantiates a new workbookFilterCriteria and sets the default values.
        /// </summary>
        public WorkbookFilterCriteria() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"color", (o,n) => { (o as WorkbookFilterCriteria).Color = n.GetStringValue(); } },
                {"criterion1", (o,n) => { (o as WorkbookFilterCriteria).Criterion1 = n.GetStringValue(); } },
                {"criterion2", (o,n) => { (o as WorkbookFilterCriteria).Criterion2 = n.GetStringValue(); } },
                {"dynamicCriteria", (o,n) => { (o as WorkbookFilterCriteria).DynamicCriteria = n.GetStringValue(); } },
                {"filterOn", (o,n) => { (o as WorkbookFilterCriteria).FilterOn = n.GetStringValue(); } },
                {"icon", (o,n) => { (o as WorkbookFilterCriteria).Icon = n.GetObjectValue<WorkbookIcon>(); } },
                {"operator", (o,n) => { (o as WorkbookFilterCriteria).Operator = n.GetStringValue(); } },
                {"values", (o,n) => { (o as WorkbookFilterCriteria).Values = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("color", Color);
            writer.WriteStringValue("criterion1", Criterion1);
            writer.WriteStringValue("criterion2", Criterion2);
            writer.WriteStringValue("dynamicCriteria", DynamicCriteria);
            writer.WriteStringValue("filterOn", FilterOn);
            writer.WriteObjectValue<WorkbookIcon>("icon", Icon);
            writer.WriteStringValue("operator", Operator);
            writer.WriteObjectValue<Json>("values", Values);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
