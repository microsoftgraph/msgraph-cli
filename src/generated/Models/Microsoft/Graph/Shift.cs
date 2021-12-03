using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Shift : ChangeTrackedEntity, IParsable {
        /// <summary>The draft version of this shift that is viewable by managers. Required.</summary>
        public ShiftItem DraftShift { get; set; }
        /// <summary>ID of the scheduling group the shift is part of. Required.</summary>
        public string SchedulingGroupId { get; set; }
        /// <summary>The shared version of this shift that is viewable by both employees and managers. Required.</summary>
        public ShiftItem SharedShift { get; set; }
        /// <summary>ID of the user assigned to the shift. Required.</summary>
        public string UserId { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"draftShift", (o,n) => { (o as Shift).DraftShift = n.GetObjectValue<ShiftItem>(); } },
                {"schedulingGroupId", (o,n) => { (o as Shift).SchedulingGroupId = n.GetStringValue(); } },
                {"sharedShift", (o,n) => { (o as Shift).SharedShift = n.GetObjectValue<ShiftItem>(); } },
                {"userId", (o,n) => { (o as Shift).UserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ShiftItem>("draftShift", DraftShift);
            writer.WriteStringValue("schedulingGroupId", SchedulingGroupId);
            writer.WriteObjectValue<ShiftItem>("sharedShift", SharedShift);
            writer.WriteStringValue("userId", UserId);
        }
    }
}
