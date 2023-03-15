using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class ScheduleChangeRequest : ChangeTrackedEntity, IParsable {
        /// <summary>The assignedTo property</summary>
        public ScheduleChangeRequestActor? AssignedTo { get; set; }
        /// <summary>The managerActionDateTime property</summary>
        public DateTimeOffset? ManagerActionDateTime { get; private set; }
        /// <summary>The managerActionMessage property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagerActionMessage { get; set; }
#nullable restore
#else
        public string ManagerActionMessage { get; set; }
#endif
        /// <summary>The managerUserId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagerUserId { get; private set; }
#nullable restore
#else
        public string ManagerUserId { get; private set; }
#endif
        /// <summary>The senderDateTime property</summary>
        public DateTimeOffset? SenderDateTime { get; private set; }
        /// <summary>The senderMessage property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SenderMessage { get; set; }
#nullable restore
#else
        public string SenderMessage { get; set; }
#endif
        /// <summary>The senderUserId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SenderUserId { get; private set; }
#nullable restore
#else
        public string SenderUserId { get; private set; }
#endif
        /// <summary>The state property</summary>
        public ScheduleChangeState? State { get; set; }
        /// <summary>
        /// Instantiates a new scheduleChangeRequest and sets the default values.
        /// </summary>
        public ScheduleChangeRequest() : base() {
            OdataType = "#microsoft.graph.scheduleChangeRequest";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ScheduleChangeRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.offerShiftRequest" => new OfferShiftRequest(),
                "#microsoft.graph.openShiftChangeRequest" => new OpenShiftChangeRequest(),
                "#microsoft.graph.swapShiftsChangeRequest" => new SwapShiftsChangeRequest(),
                "#microsoft.graph.timeOffRequest" => new TimeOffRequest(),
                _ => new ScheduleChangeRequest(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignedTo", n => { AssignedTo = n.GetEnumValue<ScheduleChangeRequestActor>(); } },
                {"managerActionDateTime", n => { ManagerActionDateTime = n.GetDateTimeOffsetValue(); } },
                {"managerActionMessage", n => { ManagerActionMessage = n.GetStringValue(); } },
                {"managerUserId", n => { ManagerUserId = n.GetStringValue(); } },
                {"senderDateTime", n => { SenderDateTime = n.GetDateTimeOffsetValue(); } },
                {"senderMessage", n => { SenderMessage = n.GetStringValue(); } },
                {"senderUserId", n => { SenderUserId = n.GetStringValue(); } },
                {"state", n => { State = n.GetEnumValue<ScheduleChangeState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<ScheduleChangeRequestActor>("assignedTo", AssignedTo);
            writer.WriteStringValue("managerActionMessage", ManagerActionMessage);
            writer.WriteStringValue("senderMessage", SenderMessage);
            writer.WriteEnumValue<ScheduleChangeState>("state", State);
        }
    }
}
