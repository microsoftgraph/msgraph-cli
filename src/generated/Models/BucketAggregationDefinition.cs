using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class BucketAggregationDefinition : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>True to specify the sort order as descending. The default is false, with the sort order as ascending. Optional.</summary>
        public bool? IsDescending { get; set; }
        /// <summary>The minimum number of items that should be present in the aggregation to be returned in a bucket. Optional.</summary>
        public int? MinimumCount { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>A filter to define a matching criteria. The key should start with the specified prefix to be returned in the response. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrefixFilter { get; set; }
#nullable restore
#else
        public string PrefixFilter { get; set; }
#endif
        /// <summary>Specifies the manual ranges to compute the aggregations. This is only valid for non-string refiners of date or numeric type. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<BucketAggregationRange>? Ranges { get; set; }
#nullable restore
#else
        public List<BucketAggregationRange> Ranges { get; set; }
#endif
        /// <summary>The sortBy property</summary>
        public BucketAggregationSortProperty? SortBy { get; set; }
        /// <summary>
        /// Instantiates a new bucketAggregationDefinition and sets the default values.
        /// </summary>
        public BucketAggregationDefinition() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static BucketAggregationDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BucketAggregationDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"isDescending", n => { IsDescending = n.GetBoolValue(); } },
                {"minimumCount", n => { MinimumCount = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"prefixFilter", n => { PrefixFilter = n.GetStringValue(); } },
                {"ranges", n => { Ranges = n.GetCollectionOfObjectValues<BucketAggregationRange>(BucketAggregationRange.CreateFromDiscriminatorValue)?.ToList(); } },
                {"sortBy", n => { SortBy = n.GetEnumValue<BucketAggregationSortProperty>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isDescending", IsDescending);
            writer.WriteIntValue("minimumCount", MinimumCount);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("prefixFilter", PrefixFilter);
            writer.WriteCollectionOfObjectValues<BucketAggregationRange>("ranges", Ranges);
            writer.WriteEnumValue<BucketAggregationSortProperty>("sortBy", SortBy);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
