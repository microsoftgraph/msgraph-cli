using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class Attendee : AttendeeBase, IParsable {
        /// <summary>An alternate date/time proposed by the attendee for a meeting request to start and end. If the attendee hasn&apos;t proposed another time, then this property is not included in a response of a GET event.</summary>
        public TimeSlot ProposedNewTime { get; set; }
        /// <summary>The attendee&apos;s response (none, accepted, declined, etc.) for the event and date-time that the response was sent.</summary>
        public ResponseStatus Status { get; set; }
        /// <summary>
        /// Instantiates a new Attendee and sets the default values.
        /// </summary>
        public Attendee() : base() {
            OdataType = "#microsoft.graph.attendee";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Attendee CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Attendee();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"proposedNewTime", n => { ProposedNewTime = n.GetObjectValue<TimeSlot>(TimeSlot.CreateFromDiscriminatorValue); } },
                {"status", n => { Status = n.GetObjectValue<ResponseStatus>(ResponseStatus.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<TimeSlot>("proposedNewTime", ProposedNewTime);
            writer.WriteObjectValue<ResponseStatus>("status", Status);
        }
    }
}
