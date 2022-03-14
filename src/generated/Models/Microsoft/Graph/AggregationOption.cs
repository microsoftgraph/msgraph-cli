using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AggregationOption : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public BucketAggregationDefinition BucketDefinition { get; set; }
        /// <summary>Computes aggregation on the field while the field exists in current entity type. Required.</summary>
        public string Field { get; set; }
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
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AggregationOption CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AggregationOption();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"bucketDefinition", (o,n) => { (o as AggregationOption).BucketDefinition = n.GetObjectValue<BucketAggregationDefinition>(BucketAggregationDefinition.CreateFromDiscriminatorValue); } },
                {"field", (o,n) => { (o as AggregationOption).Field = n.GetStringValue(); } },
                {"size", (o,n) => { (o as AggregationOption).Size = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<BucketAggregationDefinition>("bucketDefinition", BucketDefinition);
            writer.WriteStringValue("field", Field);
            writer.WriteIntValue("size", Size);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
