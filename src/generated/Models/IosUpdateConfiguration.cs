using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class IosUpdateConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Active Hours End (active hours mean the time window when updates install should not happen)</summary>
        public Time? ActiveHoursEnd { get; set; }
        /// <summary>Active Hours Start (active hours mean the time window when updates install should not happen)</summary>
        public Time? ActiveHoursStart { get; set; }
        /// <summary>Days in week for which active hours are configured. This collection can contain a maximum of 7 elements.</summary>
        public List<DayOfWeek?> ScheduledInstallDays { get; set; }
        /// <summary>UTC Time Offset indicated in minutes</summary>
        public int? UtcTimeOffsetInMinutes { get; set; }
        /// <summary>
        /// Instantiates a new IosUpdateConfiguration and sets the default values.
        /// </summary>
        public IosUpdateConfiguration() : base() {
            OdataType = "#microsoft.graph.iosUpdateConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new IosUpdateConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosUpdateConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activeHoursEnd", n => { ActiveHoursEnd = n.GetTimeValue(); } },
                {"activeHoursStart", n => { ActiveHoursStart = n.GetTimeValue(); } },
                {"scheduledInstallDays", n => { ScheduledInstallDays = n.GetCollectionOfEnumValues<DayOfWeek>()?.ToList(); } },
                {"utcTimeOffsetInMinutes", n => { UtcTimeOffsetInMinutes = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteTimeValue("activeHoursEnd", ActiveHoursEnd);
            writer.WriteTimeValue("activeHoursStart", ActiveHoursStart);
            writer.WriteCollectionOfEnumValues<DayOfWeek>("scheduledInstallDays", ScheduledInstallDays);
            writer.WriteIntValue("utcTimeOffsetInMinutes", UtcTimeOffsetInMinutes);
        }
    }
}
