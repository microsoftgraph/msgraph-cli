using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class TimeOff : ChangeTrackedEntity, IParsable {
        /// <summary>The draft version of this timeOff that is viewable by managers. Required.</summary>
        public TimeOffItem DraftTimeOff { get; set; }
        /// <summary>The shared version of this timeOff that is viewable by both employees and managers. Required.</summary>
        public TimeOffItem SharedTimeOff { get; set; }
        /// <summary>ID of the user assigned to the timeOff. Required.</summary>
        public string UserId { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"draftTimeOff", (o,n) => { (o as TimeOff).DraftTimeOff = n.GetObjectValue<TimeOffItem>(); } },
                {"sharedTimeOff", (o,n) => { (o as TimeOff).SharedTimeOff = n.GetObjectValue<TimeOffItem>(); } },
                {"userId", (o,n) => { (o as TimeOff).UserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<TimeOffItem>("draftTimeOff", DraftTimeOff);
            writer.WriteObjectValue<TimeOffItem>("sharedTimeOff", SharedTimeOff);
            writer.WriteStringValue("userId", UserId);
        }
    }
}
