using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class OpenShift : ChangeTrackedEntity, IParsable {
        /// <summary>An unpublished open shift.</summary>
        public OpenShiftItem DraftOpenShift { get; set; }
        /// <summary>ID for the scheduling group that the open shift belongs to.</summary>
        public string SchedulingGroupId { get; set; }
        /// <summary>A published open shift.</summary>
        public OpenShiftItem SharedOpenShift { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"draftOpenShift", (o,n) => { (o as OpenShift).DraftOpenShift = n.GetObjectValue<OpenShiftItem>(); } },
                {"schedulingGroupId", (o,n) => { (o as OpenShift).SchedulingGroupId = n.GetStringValue(); } },
                {"sharedOpenShift", (o,n) => { (o as OpenShift).SharedOpenShift = n.GetObjectValue<OpenShiftItem>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<OpenShiftItem>("draftOpenShift", DraftOpenShift);
            writer.WriteStringValue("schedulingGroupId", SchedulingGroupId);
            writer.WriteObjectValue<OpenShiftItem>("sharedOpenShift", SharedOpenShift);
        }
    }
}
