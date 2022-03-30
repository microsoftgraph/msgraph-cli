using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Attendee : AttendeeBase, IParsable {
        /// <summary>An alternate date/time proposed by the attendee for a meeting request to start and end. If the attendee hasn't proposed another time, then this property is not included in a response of a GET event.</summary>
        public ApiSdk.Models.Microsoft.Graph.TimeSlot ProposedNewTime { get; set; }
        /// <summary>The attendee's response (none, accepted, declined, etc.) for the event and date-time that the response was sent.</summary>
        public ApiSdk.Models.Microsoft.Graph.ResponseStatus Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.Attendee CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Attendee();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"proposedNewTime", (o,n) => { (o as Attendee).ProposedNewTime = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.TimeSlot>(ApiSdk.Models.Microsoft.Graph.TimeSlot.CreateFromDiscriminatorValue); } },
                {"status", (o,n) => { (o as Attendee).Status = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ResponseStatus>(ApiSdk.Models.Microsoft.Graph.ResponseStatus.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.TimeSlot>("proposedNewTime", ProposedNewTime);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ResponseStatus>("status", Status);
        }
    }
}
