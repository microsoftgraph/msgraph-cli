using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class OnenoteOperation : Operation, IParsable {
        /// <summary>The error returned by the operation.</summary>
        public ApiSdk.Models.Microsoft.Graph.OnenoteOperationError Error { get; set; }
        /// <summary>The operation percent complete if the operation is still in running status.</summary>
        public string PercentComplete { get; set; }
        /// <summary>The resource id.</summary>
        public string ResourceId { get; set; }
        /// <summary>The resource URI for the object. For example, the resource URI for a copied page or section.</summary>
        public string ResourceLocation { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.OnenoteOperation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnenoteOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"error", (o,n) => { (o as OnenoteOperation).Error = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.OnenoteOperationError>(ApiSdk.Models.Microsoft.Graph.OnenoteOperationError.CreateFromDiscriminatorValue); } },
                {"percentComplete", (o,n) => { (o as OnenoteOperation).PercentComplete = n.GetStringValue(); } },
                {"resourceId", (o,n) => { (o as OnenoteOperation).ResourceId = n.GetStringValue(); } },
                {"resourceLocation", (o,n) => { (o as OnenoteOperation).ResourceLocation = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.OnenoteOperationError>("error", Error);
            writer.WriteStringValue("percentComplete", PercentComplete);
            writer.WriteStringValue("resourceId", ResourceId);
            writer.WriteStringValue("resourceLocation", ResourceLocation);
        }
    }
}
