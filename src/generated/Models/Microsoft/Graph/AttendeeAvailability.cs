using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AttendeeAvailability : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The email address and type of attendee - whether it's a person or a resource, and whether required or optional if it's a person.</summary>
        public AttendeeBase Attendee { get; set; }
        /// <summary>The availability status of the attendee. Possible values are: free, tentative, busy, oof, workingElsewhere, unknown.</summary>
        public FreeBusyStatus? Availability { get; set; }
        /// <summary>
        /// Instantiates a new attendeeAvailability and sets the default values.
        /// </summary>
        public AttendeeAvailability() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"attendee", (o,n) => { (o as AttendeeAvailability).Attendee = n.GetObjectValue<AttendeeBase>(); } },
                {"availability", (o,n) => { (o as AttendeeAvailability).Availability = n.GetEnumValue<FreeBusyStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<AttendeeBase>("attendee", Attendee);
            writer.WriteEnumValue<FreeBusyStatus>("availability", Availability);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
