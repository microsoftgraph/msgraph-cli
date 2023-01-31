using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class AggregationOption : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public BucketAggregationDefinition? BucketDefinition { get; set; }
#nullable restore
#else
        public BucketAggregationDefinition BucketDefinition { get; set; }
#endif
        /// <summary>Computes aggregation on the field while the field exists in current entity type. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Field { get; set; }
#nullable restore
#else
        public string Field { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The number of searchBucket resources to be returned. This is not required when the range is provided manually in the search request. Optional.</summary>
        public int? Size { get; set; }
        /// <summary>
        /// Instantiates a new aggregationOption and sets the default values.
        /// </summary>
        public AggregationOption() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public static AggregationOption CreateFromDiscriminatorValue(IParseNode? parseNode) {
#nullable restore
#else
        public static AggregationOption CreateFromDiscriminatorValue(IParseNode parseNode) {
#endif
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AggregationOption();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"bucketDefinition", n => { BucketDefinition = n.GetObjectValue<BucketAggregationDefinition>(BucketAggregationDefinition.CreateFromDiscriminatorValue); } },
                {"field", n => { Field = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"size", n => { Size = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<BucketAggregationDefinition>("bucketDefinition", BucketDefinition);
            writer.WriteStringValue("field", Field);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("size", Size);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
