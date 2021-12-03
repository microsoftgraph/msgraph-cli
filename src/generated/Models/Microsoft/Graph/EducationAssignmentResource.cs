using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class EducationAssignmentResource : Entity, IParsable {
        /// <summary>Indicates whether this resource should be copied to each student submission for modification and submission. Required</summary>
        public bool? DistributeForStudentWork { get; set; }
        /// <summary>Resource object that has been associated with this assignment.</summary>
        public EducationResource Resource { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"distributeForStudentWork", (o,n) => { (o as EducationAssignmentResource).DistributeForStudentWork = n.GetBoolValue(); } },
                {"resource", (o,n) => { (o as EducationAssignmentResource).Resource = n.GetObjectValue<EducationResource>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("distributeForStudentWork", DistributeForStudentWork);
            writer.WriteObjectValue<EducationResource>("resource", Resource);
        }
    }
}
