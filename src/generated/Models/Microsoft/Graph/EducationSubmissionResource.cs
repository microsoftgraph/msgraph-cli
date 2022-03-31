using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class EducationSubmissionResource : Entity, IParsable {
        /// <summary>Pointer to the assignment from which this resource was copied. If this is null, the student uploaded the resource.</summary>
        public string AssignmentResourceUrl { get; set; }
        /// <summary>Resource object.</summary>
        public ApiSdk.Models.Microsoft.Graph.EducationResource Resource { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.EducationSubmissionResource CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationSubmissionResource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assignmentResourceUrl", (o,n) => { (o as EducationSubmissionResource).AssignmentResourceUrl = n.GetStringValue(); } },
                {"resource", (o,n) => { (o as EducationSubmissionResource).Resource = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.EducationResource>(ApiSdk.Models.Microsoft.Graph.EducationResource.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("assignmentResourceUrl", AssignmentResourceUrl);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.EducationResource>("resource", Resource);
        }
    }
}
