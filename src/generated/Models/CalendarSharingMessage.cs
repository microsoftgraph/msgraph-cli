using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class CalendarSharingMessage : Message, IParsable {
        public bool? CanAccept { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CalendarSharingMessageAction? SharingMessageAction { get; set; }
#nullable restore
#else
        public CalendarSharingMessageAction SharingMessageAction { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CalendarSharingMessageAction>? SharingMessageActions { get; set; }
#nullable restore
#else
        public List<CalendarSharingMessageAction> SharingMessageActions { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SuggestedCalendarName { get; set; }
#nullable restore
#else
        public string SuggestedCalendarName { get; set; }
#endif
        /// <summary>
        /// Instantiates a new CalendarSharingMessage and sets the default values.
        /// </summary>
        public CalendarSharingMessage() : base() {
            OdataType = "#microsoft.graph.calendarSharingMessage";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public static new CalendarSharingMessage CreateFromDiscriminatorValue(IParseNode? parseNode) {
#nullable restore
#else
        public static new CalendarSharingMessage CreateFromDiscriminatorValue(IParseNode parseNode) {
#endif
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CalendarSharingMessage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"canAccept", n => { CanAccept = n.GetBoolValue(); } },
                {"sharingMessageAction", n => { SharingMessageAction = n.GetObjectValue<CalendarSharingMessageAction>(CalendarSharingMessageAction.CreateFromDiscriminatorValue); } },
                {"sharingMessageActions", n => { SharingMessageActions = n.GetCollectionOfObjectValues<CalendarSharingMessageAction>(CalendarSharingMessageAction.CreateFromDiscriminatorValue)?.ToList(); } },
                {"suggestedCalendarName", n => { SuggestedCalendarName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("canAccept", CanAccept);
            writer.WriteObjectValue<CalendarSharingMessageAction>("sharingMessageAction", SharingMessageAction);
            writer.WriteCollectionOfObjectValues<CalendarSharingMessageAction>("sharingMessageActions", SharingMessageActions);
            writer.WriteStringValue("suggestedCalendarName", SuggestedCalendarName);
        }
    }
}
