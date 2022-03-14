using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class BucketAggregationDefinition : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>True to specify the sort order as descending. The default is false, with the sort order as ascending. Optional.</summary>
        public bool? IsDescending { get; set; }
        /// <summary>The minimum number of items that should be present in the aggregation to be returned in a bucket. Optional.</summary>
        public int? MinimumCount { get; set; }
        /// <summary>A filter to define a matching criteria. The key should start with the specified prefix to be returned in the response. Optional.</summary>
        public string PrefixFilter { get; set; }
        /// <summary>Specifies the manual ranges to compute the aggregations. This is only valid for non-string refiners of date or numeric type. Optional.</summary>
        public List<BucketAggregationRange> Ranges { get; set; }
        /// <summary>The possible values are count to sort by the number of matches in the aggregation, keyAsStringto sort alphabeticaly based on the key in the aggregation, keyAsNumber for numerical sorting based on the key in the aggregation. Required.</summary>
        public BucketAggregationSortProperty? SortBy { get; set; }
        /// <summary>
        /// Instantiates a new bucketAggregationDefinition and sets the default values.
        /// </summary>
        public BucketAggregationDefinition() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static BucketAggregationDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BucketAggregationDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"isDescending", (o,n) => { (o as BucketAggregationDefinition).IsDescending = n.GetBoolValue(); } },
                {"minimumCount", (o,n) => { (o as BucketAggregationDefinition).MinimumCount = n.GetIntValue(); } },
                {"prefixFilter", (o,n) => { (o as BucketAggregationDefinition).PrefixFilter = n.GetStringValue(); } },
                {"ranges", (o,n) => { (o as BucketAggregationDefinition).Ranges = n.GetCollectionOfObjectValues<BucketAggregationRange>(BucketAggregationRange.CreateFromDiscriminatorValue).ToList(); } },
                {"sortBy", (o,n) => { (o as BucketAggregationDefinition).SortBy = n.GetEnumValue<BucketAggregationSortProperty>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isDescending", IsDescending);
            writer.WriteIntValue("minimumCount", MinimumCount);
            writer.WriteStringValue("prefixFilter", PrefixFilter);
            writer.WriteCollectionOfObjectValues<BucketAggregationRange>("ranges", Ranges);
            writer.WriteEnumValue<BucketAggregationSortProperty>("sortBy", SortBy);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
