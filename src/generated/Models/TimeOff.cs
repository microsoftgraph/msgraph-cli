using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class TimeOff : ChangeTrackedEntity, IParsable {
        /// <summary>The draft version of this timeOff that is viewable by managers. Required.</summary>
        public TimeOffItem DraftTimeOff { get; set; }
        /// <summary>The shared version of this timeOff that is viewable by both employees and managers. Required.</summary>
        public TimeOffItem SharedTimeOff { get; set; }
        /// <summary>ID of the user assigned to the timeOff. Required.</summary>
        public string UserId { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TimeOff CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TimeOff();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"draftTimeOff", n => { DraftTimeOff = n.GetObjectValue<TimeOffItem>(TimeOffItem.CreateFromDiscriminatorValue); } },
                {"sharedTimeOff", n => { SharedTimeOff = n.GetObjectValue<TimeOffItem>(TimeOffItem.CreateFromDiscriminatorValue); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
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
