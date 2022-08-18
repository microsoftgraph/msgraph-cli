using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    /// <summary>Provides operations to manage the auditLogRoot singleton.</summary>
    public class TimeOffReason : ChangeTrackedEntity, IParsable {
        /// <summary>The name of the timeOffReason. Required.</summary>
        public string DisplayName { get; set; }
        /// <summary>Supported icon types: none; car; calendar; running; plane; firstAid; doctor; notWorking; clock; juryDuty; globe; cup; phone; weather; umbrella; piggyBank; dog; cake; trafficCone; pin; sunny. Required.</summary>
        public TimeOffReasonIconType? IconType { get; set; }
        /// <summary>Indicates whether the timeOffReason can be used when creating new entities or updating existing ones. Required.</summary>
        public bool? IsActive { get; set; }
        /// <summary>
        /// Instantiates a new timeOffReason and sets the default values.
        /// </summary>
        public TimeOffReason() : base() {
            OdataType = "#microsoft.graph.timeOffReason";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TimeOffReason CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TimeOffReason();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"iconType", n => { IconType = n.GetEnumValue<TimeOffReasonIconType>(); } },
                {"isActive", n => { IsActive = n.GetBoolValue(); } },
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
