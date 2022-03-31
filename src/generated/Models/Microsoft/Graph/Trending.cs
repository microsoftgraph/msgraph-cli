using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Trending : Entity, IParsable {
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Used for navigating to the trending document.</summary>
        public ApiSdk.Models.Microsoft.Graph.Entity Resource { get; set; }
        /// <summary>Reference properties of the trending document, such as the url and type of the document.</summary>
        public ApiSdk.Models.Microsoft.Graph.ResourceReference ResourceReference { get; set; }
        /// <summary>Properties that you can use to visualize the document in your experience.</summary>
        public ApiSdk.Models.Microsoft.Graph.ResourceVisualization ResourceVisualization { get; set; }
        /// <summary>Value indicating how much the document is currently trending. The larger the number, the more the document is currently trending around the user (the more relevant it is). Returned documents are sorted by this value.</summary>
        public double? Weight { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.Trending CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Trending();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"lastModifiedDateTime", (o,n) => { (o as Trending).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"resource", (o,n) => { (o as Trending).Resource = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Entity>(ApiSdk.Models.Microsoft.Graph.Entity.CreateFromDiscriminatorValue); } },
                {"resourceReference", (o,n) => { (o as Trending).ResourceReference = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ResourceReference>(ApiSdk.Models.Microsoft.Graph.ResourceReference.CreateFromDiscriminatorValue); } },
                {"resourceVisualization", (o,n) => { (o as Trending).ResourceVisualization = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ResourceVisualization>(ApiSdk.Models.Microsoft.Graph.ResourceVisualization.CreateFromDiscriminatorValue); } },
                {"weight", (o,n) => { (o as Trending).Weight = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Entity>("resource", Resource);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ResourceReference>("resourceReference", ResourceReference);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ResourceVisualization>("resourceVisualization", ResourceVisualization);
            writer.WriteDoubleValue("weight", Weight);
        }
    }
}
