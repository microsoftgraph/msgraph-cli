using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class TimeOffReason : ChangeTrackedEntity, IParsable {
        /// <summary>The name of the timeOffReason. Required.</summary>
        public string DisplayName { get; set; }
        /// <summary>Supported icon types: none; car; calendar; running; plane; firstAid; doctor; notWorking; clock; juryDuty; globe; cup; phone; weather; umbrella; piggyBank; dog; cake; trafficCone; pin; sunny. Required.</summary>
        public TimeOffReasonIconType? IconType { get; set; }
        /// <summary>Indicates whether the timeOffReason can be used when creating new entities or updating existing ones. Required.</summary>
        public bool? IsActive { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"displayName", (o,n) => { (o as TimeOffReason).DisplayName = n.GetStringValue(); } },
                {"iconType", (o,n) => { (o as TimeOffReason).IconType = n.GetEnumValue<TimeOffReasonIconType>(); } },
                {"isActive", (o,n) => { (o as TimeOffReason).IsActive = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<TimeOffReasonIconType>("iconType", IconType);
            writer.WriteBoolValue("isActive", IsActive);
        }
    }
}
