using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class AccessReviewInactiveUsersQueryScope : AccessReviewQueryScope, IParsable {
        /// <summary>Defines the duration of inactivity. Inactivity is based on the last sign in date of the user compared to the access review instance&apos;s start date. If this property is not specified, it&apos;s assigned the default value PT0S.</summary>
        public TimeSpan? InactiveDuration { get; set; }
        /// <summary>
        /// Instantiates a new AccessReviewInactiveUsersQueryScope and sets the default values.
        /// </summary>
        public AccessReviewInactiveUsersQueryScope() : base() {
            OdataType = "#microsoft.graph.accessReviewInactiveUsersQueryScope";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AccessReviewInactiveUsersQueryScope CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessReviewInactiveUsersQueryScope();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"inactiveDuration", n => { InactiveDuration = n.GetTimeSpanValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteTimeSpanValue("inactiveDuration", InactiveDuration);
        }
    }
}
