using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class EducationFeedbackOutcome : EducationOutcome, IParsable {
        /// <summary>Teacher&apos;s written feedback to the student.</summary>
        public EducationFeedback Feedback { get; set; }
        /// <summary>A copy of the feedback property that is made when the grade is released to the student.</summary>
        public EducationFeedback PublishedFeedback { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EducationFeedbackOutcome CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationFeedbackOutcome();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"feedback", n => { Feedback = n.GetObjectValue<EducationFeedback>(EducationFeedback.CreateFromDiscriminatorValue); } },
                {"publishedFeedback", n => { PublishedFeedback = n.GetObjectValue<EducationFeedback>(EducationFeedback.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<EducationFeedback>("feedback", Feedback);
            writer.WriteObjectValue<EducationFeedback>("publishedFeedback", PublishedFeedback);
        }
    }
}
