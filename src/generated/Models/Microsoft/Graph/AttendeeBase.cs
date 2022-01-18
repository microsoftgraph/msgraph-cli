using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class AttendeeBase : Recipient, IParsable {
        /// <summary>The type of attendee. Possible values are: required, optional, resource. Currently if the attendee is a person, findMeetingTimes always considers the person is of the Required type.</summary>
        public AttendeeType? Type { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"type", (o,n) => { (o as AttendeeBase).Type = n.GetEnumValue<AttendeeType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<AttendeeType>("type", Type);
        }
    }
}
