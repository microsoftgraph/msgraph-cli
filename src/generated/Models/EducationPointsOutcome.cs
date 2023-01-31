using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class EducationPointsOutcome : EducationOutcome, IParsable {
        /// <summary>The numeric grade the teacher has given the student for this assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EducationAssignmentPointsGrade? Points { get; set; }
#nullable restore
#else
        public EducationAssignmentPointsGrade Points { get; set; }
#endif
        /// <summary>A copy of the points property that is made when the grade is released to the student.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EducationAssignmentPointsGrade? PublishedPoints { get; set; }
#nullable restore
#else
        public EducationAssignmentPointsGrade PublishedPoints { get; set; }
#endif
        /// <summary>
        /// Instantiates a new EducationPointsOutcome and sets the default values.
        /// </summary>
        public EducationPointsOutcome() : base() {
            OdataType = "#microsoft.graph.educationPointsOutcome";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public static new EducationPointsOutcome CreateFromDiscriminatorValue(IParseNode? parseNode) {
#nullable restore
#else
        public static new EducationPointsOutcome CreateFromDiscriminatorValue(IParseNode parseNode) {
#endif
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationPointsOutcome();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"points", n => { Points = n.GetObjectValue<EducationAssignmentPointsGrade>(EducationAssignmentPointsGrade.CreateFromDiscriminatorValue); } },
                {"publishedPoints", n => { PublishedPoints = n.GetObjectValue<EducationAssignmentPointsGrade>(EducationAssignmentPointsGrade.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<EducationAssignmentPointsGrade>("points", Points);
            writer.WriteObjectValue<EducationAssignmentPointsGrade>("publishedPoints", PublishedPoints);
        }
    }
}
