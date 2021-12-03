using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Trending : Entity, IParsable {
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Used for navigating to the trending document.</summary>
        public Entity Resource { get; set; }
        /// <summary>Reference properties of the trending document, such as the url and type of the document.</summary>
        public ResourceReference ResourceReference { get; set; }
        /// <summary>Properties that you can use to visualize the document in your experience.</summary>
        public ResourceVisualization ResourceVisualization { get; set; }
        /// <summary>Value indicating how much the document is currently trending. The larger the number, the more the document is currently trending around the user (the more relevant it is). Returned documents are sorted by this value.</summary>
        public double? Weight { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"lastModifiedDateTime", (o,n) => { (o as Trending).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"resource", (o,n) => { (o as Trending).Resource = n.GetObjectValue<Entity>(); } },
                {"resourceReference", (o,n) => { (o as Trending).ResourceReference = n.GetObjectValue<ResourceReference>(); } },
                {"resourceVisualization", (o,n) => { (o as Trending).ResourceVisualization = n.GetObjectValue<ResourceVisualization>(); } },
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
            writer.WriteObjectValue<Entity>("resource", Resource);
            writer.WriteObjectValue<ResourceReference>("resourceReference", ResourceReference);
            writer.WriteObjectValue<ResourceVisualization>("resourceVisualization", ResourceVisualization);
            writer.WriteDoubleValue("weight", Weight);
        }
    }
}
