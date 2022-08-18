using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class CalendarSharingMessage : Message, IParsable {
        /// <summary>The canAccept property</summary>
        public bool? CanAccept { get; set; }
        /// <summary>The sharingMessageAction property</summary>
        public CalendarSharingMessageAction SharingMessageAction { get; set; }
        /// <summary>The sharingMessageActions property</summary>
        public List<CalendarSharingMessageAction> SharingMessageActions { get; set; }
        /// <summary>The suggestedCalendarName property</summary>
        public string SuggestedCalendarName { get; set; }
        /// <summary>
        /// Instantiates a new CalendarSharingMessage and sets the default values.
        /// </summary>
        public CalendarSharingMessage() : base() {
            OdataType = "#microsoft.graph.calendarSharingMessage";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new CalendarSharingMessage CreateFromDiscriminatorValue(IParseNode parseNode) {
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
                {"sharingMessageActions", n => { SharingMessageActions = n.GetCollectionOfObjectValues<CalendarSharingMessageAction>(CalendarSharingMessageAction.CreateFromDiscriminatorValue).ToList(); } },
                {"suggestedCalendarName", n => { SuggestedCalendarName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
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
