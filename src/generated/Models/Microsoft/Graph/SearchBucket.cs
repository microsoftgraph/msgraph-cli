using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class SearchBucket : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A token containing the encoded filter to aggregate search matches by the specific key value. To use the filter, pass the token as part of the aggregationFilter property in a searchRequest object, in the format '{field}:/'{aggregationFilterToken}/''. See an example.</summary>
        public string AggregationFilterToken { get; set; }
        /// <summary>The approximate number of search matches that share the same value specified in the key property. Note that this number is not the exact number of matches.</summary>
        public int? Count { get; set; }
        /// <summary>The discrete value of the field that an aggregation was computed on.</summary>
        public string Key { get; set; }
        /// <summary>
        /// Instantiates a new searchBucket and sets the default values.
        /// </summary>
        public SearchBucket() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.SearchBucket CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SearchBucket();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"aggregationFilterToken", (o,n) => { (o as SearchBucket).AggregationFilterToken = n.GetStringValue(); } },
                {"count", (o,n) => { (o as SearchBucket).Count = n.GetIntValue(); } },
                {"key", (o,n) => { (o as SearchBucket).Key = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("aggregationFilterToken", AggregationFilterToken);
            writer.WriteIntValue("count", Count);
            writer.WriteStringValue("key", Key);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
