using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Workbooks.Item.Workbook.Functions.Match {
    public class MatchRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json LookupArray { get; set; }
        public Json LookupValue { get; set; }
        public Json MatchType { get; set; }
        /// <summary>
        /// Instantiates a new matchRequestBody and sets the default values.
        /// </summary>
        public MatchRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"lookupArray", (o,n) => { (o as MatchRequestBody).LookupArray = n.GetObjectValue<Json>(); } },
                {"lookupValue", (o,n) => { (o as MatchRequestBody).LookupValue = n.GetObjectValue<Json>(); } },
                {"matchType", (o,n) => { (o as MatchRequestBody).MatchType = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("lookupArray", LookupArray);
            writer.WriteObjectValue<Json>("lookupValue", LookupValue);
            writer.WriteObjectValue<Json>("matchType", MatchType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
