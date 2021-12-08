using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class PlannerAssignedToTaskBoardTaskFormat : Entity, IParsable {
        /// <summary>Dictionary of hints used to order tasks on the AssignedTo view of the Task Board. The key of each entry is one of the users the task is assigned to and the value is the order hint. The format of each value is defined as outlined here.</summary>
        public PlannerOrderHintsByAssignee OrderHintsByAssignee { get; set; }
        /// <summary>Hint value used to order the task on the AssignedTo view of the Task Board when the task is not assigned to anyone, or if the orderHintsByAssignee dictionary does not provide an order hint for the user the task is assigned to. The format is defined as outlined here.</summary>
        public string UnassignedOrderHint { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"orderHintsByAssignee", (o,n) => { (o as PlannerAssignedToTaskBoardTaskFormat).OrderHintsByAssignee = n.GetObjectValue<PlannerOrderHintsByAssignee>(); } },
                {"unassignedOrderHint", (o,n) => { (o as PlannerAssignedToTaskBoardTaskFormat).UnassignedOrderHint = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<PlannerOrderHintsByAssignee>("orderHintsByAssignee", OrderHintsByAssignee);
            writer.WriteStringValue("unassignedOrderHint", UnassignedOrderHint);
        }
    }
}
