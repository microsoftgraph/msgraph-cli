using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class TimeOff : ChangeTrackedEntity, IParsable {
        /// <summary>The draft version of this timeOff that is viewable by managers. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TimeOffItem? DraftTimeOff { get; set; }
#nullable restore
#else
        public TimeOffItem DraftTimeOff { get; set; }
#endif
        /// <summary>The shared version of this timeOff that is viewable by both employees and managers. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TimeOffItem? SharedTimeOff { get; set; }
#nullable restore
#else
        public TimeOffItem SharedTimeOff { get; set; }
#endif
        /// <summary>ID of the user assigned to the timeOff. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId { get; set; }
#nullable restore
#else
        public string UserId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new timeOff and sets the default values.
        /// </summary>
        public TimeOff() : base() {
            OdataType = "#microsoft.graph.timeOff";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<TimeOffItem>("draftTimeOff", DraftTimeOff);
            writer.WriteObjectValue<TimeOffItem>("sharedTimeOff", SharedTimeOff);
            writer.WriteStringValue("userId", UserId);
        }
    }
}
