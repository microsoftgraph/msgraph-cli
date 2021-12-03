using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Me.Insights.Shared.Item.Resource.WorkbookRangeSort.Apply {
    public class ApplyRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<WorkbookSortField> Fields { get; set; }
        public bool? HasHeaders { get; set; }
        public bool? MatchCase { get; set; }
        public string Method { get; set; }
        public string Orientation { get; set; }
        /// <summary>
        /// Instantiates a new applyRequestBody and sets the default values.
        /// </summary>
        public ApplyRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"fields", (o,n) => { (o as ApplyRequestBody).Fields = n.GetCollectionOfObjectValues<WorkbookSortField>().ToList(); } },
                {"hasHeaders", (o,n) => { (o as ApplyRequestBody).HasHeaders = n.GetBoolValue(); } },
                {"matchCase", (o,n) => { (o as ApplyRequestBody).MatchCase = n.GetBoolValue(); } },
                {"method", (o,n) => { (o as ApplyRequestBody).Method = n.GetStringValue(); } },
                {"orientation", (o,n) => { (o as ApplyRequestBody).Orientation = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<WorkbookSortField>("fields", Fields);
            writer.WriteBoolValue("hasHeaders", HasHeaders);
            writer.WriteBoolValue("matchCase", MatchCase);
            writer.WriteStringValue("method", Method);
            writer.WriteStringValue("orientation", Orientation);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
