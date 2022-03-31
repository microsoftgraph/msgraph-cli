using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class SearchAggregation : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Defines the actual buckets of the computed aggregation.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.SearchBucket> Buckets { get; set; }
        /// <summary>Defines on which field the aggregation was computed on.</summary>
        public string Field { get; set; }
        /// <summary>
        /// Instantiates a new searchAggregation and sets the default values.
        /// </summary>
        public SearchAggregation() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.SearchAggregation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SearchAggregation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"buckets", (o,n) => { (o as SearchAggregation).Buckets = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.SearchBucket>(ApiSdk.Models.Microsoft.Graph.SearchBucket.CreateFromDiscriminatorValue).ToList(); } },
                {"field", (o,n) => { (o as SearchAggregation).Field = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.SearchBucket>("buckets", Buckets);
            writer.WriteStringValue("field", Field);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
