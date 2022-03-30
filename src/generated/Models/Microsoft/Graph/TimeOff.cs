using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class TimeOff : ChangeTrackedEntity, IParsable {
        /// <summary>The draft version of this timeOff that is viewable by managers. Required.</summary>
        public ApiSdk.Models.Microsoft.Graph.TimeOffItem DraftTimeOff { get; set; }
        /// <summary>The shared version of this timeOff that is viewable by both employees and managers. Required.</summary>
        public ApiSdk.Models.Microsoft.Graph.TimeOffItem SharedTimeOff { get; set; }
        /// <summary>ID of the user assigned to the timeOff. Required.</summary>
        public string UserId { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.TimeOff CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TimeOff();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"draftTimeOff", (o,n) => { (o as TimeOff).DraftTimeOff = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.TimeOffItem>(ApiSdk.Models.Microsoft.Graph.TimeOffItem.CreateFromDiscriminatorValue); } },
                {"sharedTimeOff", (o,n) => { (o as TimeOff).SharedTimeOff = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.TimeOffItem>(ApiSdk.Models.Microsoft.Graph.TimeOffItem.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.TimeOffItem>("draftTimeOff", DraftTimeOff);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.TimeOffItem>("sharedTimeOff", SharedTimeOff);
            writer.WriteStringValue("userId", UserId);
        }
    }
}
